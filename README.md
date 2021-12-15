
[![NuGet Badge](https://img.shields.io/nuget/v/LightstonePlatform.Products)](https://www.nuget.org/packages/LightstonePlatform.Products/)
# Getting Started

Lightstone Platform Products is a library intended to allow for the surfacing of your products on the Lightstone platform, this package provides you with the required .Net classes to be able to respond to platform requests.

## Install Lightstone Platform Products via NuGet

```
PM> Install-Package LightstonePlatform.Products -Version 0.1.5
```

## Sample Usage

``` C#
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ProductFlowController<HelloWorldInput>
    {
        const string INPUT_ELEMENT_NAME = "hello-world-input";
        const string FINAL_ELEMENT_NAME = "hello-world";

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

    }
```

## Documentation

See our detailed [documentation](https://github.com/Lightstone-Group/LightstonePlatform.Products/blob/main/docs/index.md) for more information
# Support



# License

