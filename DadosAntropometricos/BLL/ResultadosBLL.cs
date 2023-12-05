using AcompanhamentoFisico.DTO;
using DadosAntropometricos.DAO;

namespace DadosAntropometricos.BLL
{
    public class ResultadosBLL
    {
        MedidasAtuaisDAO daoAtual = new MedidasAtuaisDAO();
        MedidasObjetivoDAO daoObjetivo = new MedidasObjetivoDAO();

        public MedidasDTO MostraDiferencaParaObjetivo(String CPF)
        {
            MedidasDTO medidasAtuais =  daoAtual.retornaMedidasAtuais(CPF);
            MedidasDTO medidasObjetivo = daoObjetivo.retornaMedidasObjetivo(CPF);

            MedidasDTO medidasDiferenca = new MedidasDTO();

            #region peso
            if (medidasAtuais.peso >= medidasObjetivo.peso)
            {
                medidasDiferenca.peso = medidasObjetivo.peso - medidasAtuais.peso;
            }
            else
            {
                medidasDiferenca.peso = medidasAtuais.peso - medidasObjetivo.peso;
            }


            #endregion

            #region circunferenciaAbdominal
            if (medidasAtuais.circunferenciaAbdominal >= medidasObjetivo.circunferenciaAbdominal)
            {
                medidasDiferenca.circunferenciaAbdominal = medidasObjetivo.circunferenciaAbdominal - medidasAtuais.circunferenciaAbdominal;
            }
            else
            {
                medidasDiferenca.circunferenciaAbdominal = medidasAtuais.circunferenciaAbdominal - medidasObjetivo.circunferenciaAbdominal;
            }
            #endregion

            # region ombro
            if (medidasAtuais.ombro >= medidasObjetivo.ombro)
            {
                medidasDiferenca.ombro = medidasObjetivo.ombro - medidasAtuais.ombro;
            }
            else
            {
                medidasDiferenca.ombro = medidasAtuais.ombro - medidasObjetivo.ombro;
            }
            #endregion


            #region peitoral
            if (medidasAtuais.peitoral >= medidasObjetivo.peitoral)
            {
                medidasDiferenca.peitoral = medidasObjetivo.peitoral - medidasAtuais.peitoral;
            }
            else
            {
                medidasDiferenca.peitoral = medidasAtuais.peitoral - medidasObjetivo.peitoral;
            }
            #endregion

            #region bracoEsquerdo
            if (medidasAtuais.bracoEsquerdo >= medidasObjetivo.bracoEsquerdo)
            {
                medidasDiferenca.bracoEsquerdo = medidasObjetivo.bracoEsquerdo - medidasAtuais.bracoEsquerdo;
            }
            else
            {
                medidasDiferenca.bracoEsquerdo = medidasAtuais.bracoEsquerdo - medidasObjetivo.bracoEsquerdo;
            }
            #endregion

            #region bracoDireito
            if (medidasAtuais.bracoDireito >= medidasObjetivo.bracoDireito)
            {
                medidasDiferenca.bracoDireito = medidasObjetivo.bracoDireito - medidasAtuais.bracoDireito;
            }
            else
            {
                medidasDiferenca.bracoDireito = medidasAtuais.bracoDireito - medidasObjetivo.bracoDireito;
            }
            #endregion


            #region coxaEsquerda
            if (medidasAtuais.coxaEsquerda >= medidasObjetivo.coxaEsquerda)
            {
                medidasDiferenca.coxaEsquerda = medidasObjetivo.coxaEsquerda - medidasAtuais.coxaEsquerda;
            }
            else
            {
                medidasDiferenca.coxaEsquerda = medidasAtuais.coxaEsquerda - medidasObjetivo.coxaEsquerda;
            }
            #endregion


            #region coxaDireita
            if (medidasAtuais.coxaDireita >= medidasObjetivo.coxaDireita)
            {
                medidasDiferenca.coxaDireita = medidasObjetivo.coxaDireita - medidasAtuais.coxaDireita;
            }
            else
            {
                medidasDiferenca.coxaDireita = medidasAtuais.coxaDireita - medidasObjetivo.coxaDireita;
            }
            #endregion

            #region bicepsEsquerdo
            if (medidasAtuais.bicepsEsquerdo >= medidasObjetivo.bicepsEsquerdo)
            {
                medidasDiferenca.bicepsEsquerdo = medidasObjetivo.bicepsEsquerdo - medidasAtuais.bicepsEsquerdo;
            }
            else
            {
                medidasDiferenca.bicepsEsquerdo = medidasAtuais.bicepsEsquerdo - medidasObjetivo.bicepsEsquerdo;
            }
            #endregion

            #region bicepsDireito
            if (medidasAtuais.bicepsDireito >= medidasObjetivo.bicepsDireito)
            {
                medidasDiferenca.bicepsDireito = medidasObjetivo.bicepsDireito - medidasAtuais.bicepsDireito;
            }
            else
            {
                medidasDiferenca.bicepsDireito = medidasAtuais.bicepsDireito - medidasObjetivo.bicepsDireito;
            }
            #endregion

            #region antebracoEsquerdo
            if (medidasAtuais.antebracoEsquerdo >= medidasObjetivo.antebracoEsquerdo)
            {
                medidasDiferenca.antebracoEsquerdo = medidasObjetivo.antebracoEsquerdo - medidasAtuais.antebracoEsquerdo;
            }
            else
            {
                medidasDiferenca.antebracoEsquerdo = medidasAtuais.antebracoEsquerdo - medidasObjetivo.antebracoEsquerdo;
            }
            #endregion


            #region antebracoDireito
            if (medidasAtuais.antebracoDireito >= medidasObjetivo.antebracoDireito)
            {
                medidasDiferenca.antebracoDireito = medidasObjetivo.antebracoDireito - medidasAtuais.antebracoDireito;
            }
            else
            {
                medidasDiferenca.antebracoDireito = medidasAtuais.antebracoDireito - medidasObjetivo.antebracoDireito;
            }
            #endregion

            #region panturrilhaEsquerda
            if (medidasAtuais.panturrilhaEsquerda >= medidasObjetivo.panturrilhaEsquerda)
            {
                medidasDiferenca.panturrilhaEsquerda = medidasObjetivo.panturrilhaEsquerda - medidasAtuais.panturrilhaEsquerda;
            }
            else
            {
                medidasDiferenca.panturrilhaEsquerda = medidasAtuais.panturrilhaEsquerda - medidasObjetivo.panturrilhaEsquerda;
            }
            #endregion


            #region panturrilhaDireita
            if (medidasAtuais.panturrilhaDireita >= medidasObjetivo.panturrilhaDireita)
            {
                medidasDiferenca.panturrilhaDireita = medidasObjetivo.panturrilhaDireita - medidasAtuais.panturrilhaDireita;
            }
            else
            {
                medidasDiferenca.panturrilhaDireita = medidasAtuais.panturrilhaDireita - medidasObjetivo.panturrilhaDireita;
            }
            #endregion


            #region quadril
            if (medidasAtuais.quadril >= medidasObjetivo.quadril)
            {
                medidasDiferenca.quadril = medidasObjetivo.quadril - medidasAtuais.quadril;
            }
            else
            {
                medidasDiferenca.quadril = medidasAtuais.quadril - medidasObjetivo.quadril;
            }
            #endregion


            #region gluteos
            if (medidasAtuais.gluteos >= medidasObjetivo.gluteos)
            {
                medidasDiferenca.gluteos = medidasObjetivo.gluteos - medidasAtuais.gluteos;
            }
            else
            {
                medidasDiferenca.gluteos = medidasAtuais.gluteos - medidasObjetivo.gluteos;
            }
            #endregion
            return medidasDiferenca;
        }

    }
}
