﻿using AcompanhamentoFisico.DTO;
using DadosAntropometricos.BLL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DadosAntropometricos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultadosController : ControllerBase
    {

        ResultadosBLL bll = new ResultadosBLL();

        [HttpGet("{CPF}")]
        public MedidasDTO BuscaPorCPF(String CPF)
        {

            MedidasDTO medidasDTO = bll.MostraDiferencaParaObjetivo(CPF);



            return medidasDTO;
        }

    }
}