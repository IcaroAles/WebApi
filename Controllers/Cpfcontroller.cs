using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("cpf/")]
public class CpfController : ControllerBase
{
   [HttpGet("validate/cpf")]
   public object Validate (
       [FromServices]CpfServices CpfService,
       string cpf)
   {
       throw new NotImplementedException();
   }

   [HttpGet("generate")]
   public object Generate()
   {
       throw new NotImplementedException();
   }
}