using AcompanhamentoFisico.BLL;
using AcompanhamentoFisico.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AcompanhamentoFisico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedidasIniciaisController : ControllerBase
    {
        MedidasIniciaisBLL bll = new MedidasIniciaisBLL();

        [HttpGet("{CPF}")]
        public MedidasDTO BuscaPorCPF(String CPF)
        {

            MedidasDTO medidasDTO = bll.retornaAcademiaPorCPF(CPF);
         


            return medidasDTO;
        }

        [HttpPost]
        public String Post(MedidasDTO medidasDTO,String CPF)
        {
            String retorno = bll.insereMedidasIniciais(medidasDTO, CPF);

            return retorno;

        }
        

        [HttpDelete("{CPF}")]
        public String Delete(String CPF)
        {
            String retorno = bll.deletaMedidasAtuais(CPF);

            return retorno;
        }



        [HttpPut]
        public String Put(MedidasDTO medidasDTO,String CPF)
        {
            String retorno = bll.alteraMedidasIniciais(medidasDTO, CPF);

            return retorno;
        }
    }
}
