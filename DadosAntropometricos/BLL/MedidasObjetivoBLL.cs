using AcompanhamentoFisico.DTO;
using DadosAntropometricos.DAO;

namespace DadosAntropometricos.BLL
{
    public class MedidasObjetivoBLL
    {
        int retornoMedidas;

        MedidasObjetivoDAO dao = new MedidasObjetivoDAO();
        public String insereMedidasObjetivo(MedidasDTO medidasDTO, String CPF)
        {
            retornoMedidas = 0;

            retornoMedidas = dao.insereMedidasObjetivo(medidasDTO, CPF);


            return retornoMedidas == 1 ? "Cadastro realizado com sucesso" : "Não foi possível cadastrar medidas objetivo";
        }

        public MedidasDTO retornaMedidasObjetivoPorCPF(String CPF)
        {

            MedidasDTO medidasDTO = dao.retornaMedidasObjetivo(CPF);

            return medidasDTO;
        }
        public String deletaMedidasObjetivo(String CPF)
        {
            String retorno = "";
            int retornoMedidas = 0;


            if (CPF != null)
            {
                retornoMedidas = dao.deletaMedidasObjetivo(CPF);
            }

            if (retornoMedidas == 1)
            {
                retorno = "Deletado com sucesso";
            }
            else
            {
                retorno = "Não foi possível deletado medidas objetivo";
            }


            return retorno;
        }

        public String alteraMedidasObjetivo(MedidasDTO medidasDTO, String CPF)
        {
            retornoMedidas = 0;

            retornoMedidas = dao.alteraMedidasObjetivo(medidasDTO, CPF);

            return retornoMedidas == 1 ? "Alteração realizada com sucesso" : "Não foi possível alterar medidas objetivo";
        }
    }

}
