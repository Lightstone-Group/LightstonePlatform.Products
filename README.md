
[![NuGet Badge](https://img.shields.io/nuget/v/LightstonePlatform.Products)](https://www.nuget.org/packages/LightstonePlatform.Products/)
# Getting Started

Lightstone Platform Products is a library intended to allow for the surfacing of your products on the Lightstone platform. This package provides you with the required .Net classes to be able to respond to platform requests.

## Install Lightstone Platform Products via NuGet

```
PM> Install-Package LightstonePlatform.Products
```

## Sample Usage

A sample Hello World product is available [here](https://github.com/Lightstone-Group/Product.Sample.AspDotNet)

Below you can see the essential parts of the implementation.
``` C#
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ProductFlowController<HelloWorldInput>
    {
        const string INPUT_ELEMENT_NAME = "hello-world-input";
        const string FINAL_ELEMENT_NAME = "hello-world";
        const string ERROR_ELEMENT_NAME = "hello-world-error";

        public async override Task<ActionResult<StartResponse>> Start([FromBody] ProductFlowInstanceStartModel input)
        {
            return new ShowUIStartResponse
            {
                ElementName = INPUT_ELEMENT_NAME
            };
        }

        public async override Task<ActionResult<ValidateInputResponse>> ValidateInputs([FromBody] ProductFlowInstanceInput<HelloWorldInput> input)
        {
            return new ValidateInputResponse()
            {
                Succesful = true,
                ProductDesctiption = $"{input.Data.Name}"
            };
        }

        public async override Task<ActionResult<ProcessResponse>> Process([FromBody] ProductFlowInstanceProcessModel<HelloWorldInput> input)
        {
            return new ShowUIProcessResponse
            {
                Attributes = { { "name", input.Input.Data.Name } },
                ElementName = FINAL_ELEMENT_NAME
            };
        }

        public async override Task<ActionResult<HandleErrorResponse>> HandleError([FromBody] ProductFlowInstanceHandleErrorModel errorInput)
        {
            return new ShowUIHandleErrorResponse
            {
                ElementName = ERROR_ELEMENT_NAME,
                ElementUrl = ERROR_ELEMENT_URL,
                Attributes = { { "error-status", errorInput.ProductFlowInstanceStatus }},
                Body = ""
            };
        }

    }
```

## Documentation

See our detailed [documentation](https://apex.coaxle.co.za/docs/product-flow/product-implementation) for more information
# Support



# License

