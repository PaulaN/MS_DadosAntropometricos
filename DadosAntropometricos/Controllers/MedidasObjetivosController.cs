using AcompanhamentoFisico.BLL;
using AcompanhamentoFisico.DTO;
using DadosAntropometricos.BLL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DadosAntropometricos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedidasObjetivosController : ControllerBase
    {
        MedidasObjetivoBLL bll = new MedidasObjetivoBLL();

        [HttpGet("{CPF}")]
        public MedidasDTO BuscaPorCPF(String CPF)
        {

            MedidasDTO medidasDTO = bll.retornaMedidasObjetivoPorCPF(CPF);



            return medidasDTO;
        }

        [HttpPost]
        public String Post(MedidasDTO medidasDTO, String CPF)
        {
            String retorno = bll.insereMedidasObjetivo(medidasDTO, CPF);

            return retorno;

        }


        [HttpDelete("{CPF}")]
        public String Delete(String CPF)
        {
            String retorno = bll.deletaMedidasObjetivo(CPF);

            return retorno;
        }



        [HttpPut]
        public String Put(MedidasDTO medidasDTO, String CPF)
        {
            String retorno = bll.alteraMedidasObjetivo(medidasDTO, CPF);

            return retorno;
        }
    }
}
