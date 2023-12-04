using AcompanhamentoFisico.DTO;
using DadosAntropometricos.DAO;

namespace DadosAntropometricos.BLL
{
    public class MedidasAtuaisBLL
    {
        int retornoMedidas;

      MedidasAtuaisDAO dao = new MedidasAtuaisDAO();
        public String insereMedidasAtuais(MedidasDTO medidasDTO, String CPF)
        {
            retornoMedidas = 0;

            retornoMedidas = dao.insereMedidasAtuais(medidasDTO, CPF);


            return retornoMedidas == 1 ? "Cadastro realizado com sucesso" : "Não foi possível cadastrar medidas iniciais";
        }

        public MedidasDTO retornaMedidasAtuaisPorCPF(String CPF)
        {

            MedidasDTO medidasDTO = dao.retornaMedidasAtuais(CPF);

            return medidasDTO;
        }
        public String deletaMedidasAtuais(String CPF)
        {
            String retorno = "";
            int retornoMedidas = 0;


            if (CPF != null)
            {
                retornoMedidas = dao.deletaMedidasAtuais(CPF);
            }

            if (retornoMedidas == 1)
            {
                retorno = "Deletado com sucesso";
            }
            else
            {
                retorno = "Não foi possível deletado medidas atuais";
            }


            return retorno;
        }

        public String alteraMedidasAtuais(MedidasDTO medidasDTO, String CPF)
        {
            retornoMedidas = 0;

            retornoMedidas = dao.alteraMedidasAtuais(medidasDTO, CPF);

            return retornoMedidas == 1 ? "Alteração realizada com sucesso" : "Não foi possível alterar medidas atuais";
        }
    }
}
