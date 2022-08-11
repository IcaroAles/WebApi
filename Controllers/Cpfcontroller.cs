using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("cpf/")]
public class CpfController : ControllerBase
{
   [HttpGet("validate/cpf")]
   public object Validate (string cpf)
   {
       throw new NotImplementException();
   }

   [HttpGet("generate")]
   public object Generate()
   {
       throw new NotImplementException();
   }
}