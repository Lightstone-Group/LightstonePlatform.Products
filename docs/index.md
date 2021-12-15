# Introduction

Lightstone Platform Product is a library intended to support product developers to surface their products through and leverage the Lightstone platform.

The Lightstone Platform comprises of a product flow that always follows the sames steps to surface a product through the product flow web component. This library serves as the basis for all products that are built and surfaced through the Lightstone Platform, and contains all needed models and end points to be able to successfully surface your product.
# Product Implementation
## Product Flow Explained

When a tenant on the platform initiates a new product flow, the flow goes through various steps to determine what should be displayed to the user. The flow is made up of the following steps:

- Initiation
    - The tenant is responsible for initiating the start request to the platform. This request is used by all tenants on platform to be able to surface a product through platform.
- Legal
    - The platform gets the data from the product catalogue for the product that was specified when initiating the flow and determines if there is any legal requirements for this flow to proceed and will automatically get any inputs from the user if required.
- Start
    - This is the first time that the platform will need to communicate with your new product. The platform will do an API request to your product based on the configured base url for your product by calling the Start end-point.  Your product needs to return a relevant response as per the steps below.
- Verify Inputs
    - If the response in the start end-point indicated that inputs were required from the user, the platform will surface your web component to the user. It will then collect that data from the user and send that data back to your product using the Verify Inputs end-point. Your product will then determine if the input received is valid and if the flow can proceed
- Quoting
    - Platform will then generate a quote for the product, if the user is on a contract and usage of the product is allowed based on the contract configuration the flow will continue, if not the quote will be displayed to the user on the tenant for input
- Payment
    - Upon quote acceptance platform uses the payment method specified by the quote to collect funds from the end user, either through debit order or credit card payment.
- Process
    - Once the above steps complete successfully platform will call your product on the Process end-point which will then result in surfacing of the final purchased product.
## Product API Implementation

Your product needs to implement the following based end-points to be compatible with platform, each end-point has pre-defined expected responses that needs to be returned and this library enables you to quickly get your product up and running.
### Start

The start end-point is where everything begins, this end-point is what allows platform to initialize your product, Platform expects one of two responses ``` ShowUIStartResponse ``` or ``` ContinueStartResponse ```

#### Samples:

If your product requires no inputs from the end user, your response needs to be a ```ContinueStartResponse``` which indcated to platform to continue with the product flow without having to wait for user input.

``` C#
    public async override Task<ActionResult<StartResponse>> Start([FromBody] ProductFlowInstanceStartModel input)
    {
        return new ContinueStartResponse
        {
            ProductDescription = "PRODUCT NAME"
        };
    }
```

If you require user input before you can successfully produce your end product you need to return a ```ShowUIStartResponse``` this response needs to contain a URL for a Web Component to be rendered in the tenant to collect user input, and the element name for the custom web component to be rendered.

``` C#
    public async override Task<ActionResult<StartResponse>> Start([FromBody] ProductFlowInstanceStartModel input)
    {
        return new ShowUIStartResponse
        {
            ElementName = INPUT_ELEMENT_NAME,
            ElementUrl = INPUT_ELEMENT_URL
        };
    }
```
### Validate Inputs

When the user has completed the inputs from a ```ShowUIStartResponse```, the inputs will be posted to the Validate Inputs end-point. The inputs should be validated and a relevant response be returned. If the validation fails, the platform will display the inputs screen again for the user to complete.

#### Sample

``` C#
    public async override Task<ActionResult<ValidateInputResponse>> ValidateInputs([FromBody] ProductFlowInstanceInput<HelloWorldInput> input)
    {
        return new ValidateInputResponse()
        {
            Succesful = true
        };
    }

```
### Process

After successfully completing all steps platform will call the Process end-point on your product API, this end-point will then return either a ```ContinueProcessResponse``` or a ```ShowUIProcessResponse``` based on the data posted to the Process end-point

#### Samples

``` C#
    public async override Task<ActionResult<ProcessResponse>> Process([FromBody] ProductFlowInstanceProcessModel<HelloWorldInput> input)
    {
        return new ContinueProcessResponse();
    }
```

``` C#
    public async override Task<ActionResult<ProcessResponse>> Process([FromBody] ProductFlowInstanceProcessModel<HelloWorldInput> input)
    {
        return new ShowUIProcessResponse
        {
            Attributes = { { "name", input.Input.Data.Name } },
            ElementName = FINAL_ELEMENT_NAME,
            ElementUrl = FINAL_ELEMENT_URL,
            Body = ""
        };
    }
```

Please see the [samples project](https://github.com/Lightstone-Group/Product.Sample.AspDotNet) for implementation example

### Attributes and Body

- Body
    - The body property of the Show UI Responses contains a JSON string for data that needs to be passed back to your custom web component
- Attributes
    - The attributes property of the ShowUI Responses is a dictionary of key value pairs that will be set as attributes for your custom web component
    - Ex result: 
    ``` C#
        return new ShowUIProcessResponse
        {
            Attributes = { { "custom-attr", "value" } },
            ElementName = "custom-component"
        };
    ```
    will result in
    ```html 
    <custom-component custom-attr="value"></custom-component> 
    ```

## Micro Front End

Your product also needs to contain Micro Front Ends which are custom web components that the platform will render on the tenant based on the responses from your product API.