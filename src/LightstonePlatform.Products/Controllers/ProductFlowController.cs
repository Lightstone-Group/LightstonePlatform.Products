using LightstonePlatform.Products.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LightstonePlatform.Products.Controllers
{
    public abstract class ProductFlowController : ProductFlowController<object>
    {
    }

    public abstract class ProductFlowController<TData> : ControllerBase
    {
        [HttpPost]
        [Route("start")]
        public abstract Task<ActionResult<StartResponse>> Start([FromBody] ProductFlowInstanceStart input);
        [HttpPost]
        [Route("inputs/validate")]
        public abstract Task<ActionResult<ValidateInputResponse>> ValidateInputs([FromBody] ProductFlowInstanceInput<TData> input);
        [HttpPost]
        [Route("process")]
        public abstract Task<ActionResult<ProcessResponse>> Process([FromBody] ProductFlowInstanceProcess<TData> input);
        [HttpPost]
        [Route("handle/error")]
        public abstract Task<ActionResult<HandleErrorResponse>> HandleError([FromBody] ProductFlowInstance<TData> errorInput);

    }
}
