using AcompanhamentoFisico.BLL;
using AcompanhamentoFisico.DTO;
using DadosAntropometricos.BLL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DadosAntropometricos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedidasAtuaisController : ControllerBase
    {
        MedidasAtuaisBLL bll = new MedidasAtuaisBLL();

        [HttpGet("{CPF}")]
        public MedidasDTO BuscaPorCPF(String CPF)
        {

            MedidasDTO medidasDTO = bll.retornaMedidasAtuaisPorCPF(CPF);



            return medidasDTO;
        }

        [HttpPost]
        public String Post(MedidasDTO medidasDTO, String CPF)
        {
            String retorno = bll.insereMedidasAtuais(medidasDTO, CPF);

            return retorno;

        }


        [HttpDelete("{CPF}")]
        public String Delete(String CPF)
        {
            String retorno = bll.deletaMedidasAtuais(CPF);

            return retorno;
        }



        [HttpPut]
        public String Put(MedidasDTO medidasDTO, String CPF)
        {
            String retorno = bll.alteraMedidasAtuais(medidasDTO, CPF);

            return retorno;
        }
    }
}
