using AcompanhamentoFisico.DAO;
using AcompanhamentoFisico.DTO;

namespace AcompanhamentoFisico.BLL
{
    public class MedidasIniciaisBLL
    {

        MedidasIniciaisDAO dao = new MedidasIniciaisDAO();

        int retornoMedidas;
       
        public String insereMedidasIniciais(MedidasDTO medidasDTO,String CPF)
        {
            retornoMedidas = 0;

            retornoMedidas = dao.insereMedidas(medidasDTO,CPF);


            return retornoMedidas == 1 ? "Cadastro realizado com sucesso" : "Não foi possível cadastrar medidas iniciais";
        }

        public MedidasDTO retornaAcademiaPorCPF(String CPF)
        {

            MedidasDTO medidasDTO = dao.retornaMedidas(CPF);

            return medidasDTO;
        }
        public String deletaMedidasAtuais(String CPF)
        {
            String retorno = "";
            int retornoMedidas = 0;


            if (CPF != null)
            {
               retornoMedidas = dao.deletaMedidas(CPF);
            }

            if(retornoMedidas==1)
            {
                retorno = "Deletado com sucesso";
            }
            else
            {
                retorno = "Não foi possível deletado medidas iniciais";
            }


            return retorno;
        }

        public String alteraMedidasIniciais(MedidasDTO medidasDTO,String CPF)
        {
            retornoMedidas = 0;

            retornoMedidas = dao.alteraMedidas(medidasDTO,CPF);

            return retornoMedidas == 1 ? "Alteração realizada com sucesso" : "Não foi possível alterar medidas iniciais";
        }


    }
}
