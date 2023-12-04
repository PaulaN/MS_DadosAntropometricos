using AcompanhamentoFisico.DTO;
using AcompanhamentoFisico.Model;
using AutoMapper;
using System.Data.SqlClient;
using System.Data;

namespace DadosAntropometricos.DAO
{
    public class MedidasObjetivoDAO
    {
        String conexao = @"Server=DESKTOP-BJNTUCI\MSSQLSERVER01;Database=Cliente;Trusted_Connection=True";
        public MedidasDTO retornaMedidasObjetivo(String CPF)
        {
            MedidasDTO medidasDTO = new MedidasDTO();
            Medidas medidas = new Medidas();

            string sql = "Select id_medidas,peso,altura,circunferencia_abdominal,IMC,ombro,peitoral,braco_esquerdo,braco_direito,coxa_esquerda,coxa_direita,biceps_esquerdo,biceps_direito,antebraco_direito,antebraco_esquerdo,panturrilha_esquerda,panturrilha_direita,quadril,gluteos,id_fk_cliente FROM dbo.Medidas_Antropometricas_Objetivo medidas  inner join dbo.DadosPessoaisCliente dadosPessoais on medidas.id_fk_cliente = dadosPessoais.id_pk_cliente where CPF =" + "'" + CPF + "'";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    medidas.id_medidas = Convert.ToInt32(reader["id_medidas"]);
                    medidas.peso = Convert.ToDecimal(reader["peso"]);
                    medidas.altura = Convert.ToDecimal(reader["altura"]);
                    medidas.circunferenciaAbdominal = Convert.ToDecimal(reader["circunferencia_abdominal"]);
                    medidas.IMC = Convert.ToDecimal(reader["IMC"]);
                    medidas.ombro = Convert.ToDecimal(reader["ombro"]);
                    medidas.peitoral = Convert.ToDecimal(reader["peitoral"]);
                    medidas.bracoEsquerdo = Convert.ToDecimal(reader["braco_esquerdo"]);
                    medidas.bracoDireito = Convert.ToDecimal(reader["braco_direito"]);
                    medidas.coxaDireita = Convert.ToDecimal(reader["coxa_direita"]);
                    medidas.coxaEsquerda = Convert.ToDecimal(reader["coxa_esquerda"]);
                    medidas.bicepsEsquerdo = Convert.ToDecimal(reader["biceps_esquerdo"]);
                    medidas.bicepsDireito = Convert.ToDecimal(reader["biceps_direito"]);
                    medidas.antebracoDireito = Convert.ToDecimal(reader["antebraco_direito"]);
                    medidas.antebracoEsquerdo = Convert.ToDecimal(reader["antebraco_esquerdo"]);
                    medidas.panturrilhaEsquerda = Convert.ToDecimal(reader["panturrilha_esquerda"]);
                    medidas.panturrilhaDireita = Convert.ToDecimal(reader["panturrilha_direita"]);
                    medidas.quadril = Convert.ToDecimal(reader["quadril"]);
                    medidas.gluteos = Convert.ToDecimal(reader["gluteos"]);
                    medidas.idCliente = Convert.ToInt32(reader["id_fk_cliente"]);



                    var configuration = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<Medidas, MedidasDTO>();
                    });
                    var mapper = configuration.CreateMapper();
                    medidasDTO = mapper.Map<MedidasDTO>(medidas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                con.Close();
            }

            return medidasDTO;
        }
        public int insereMedidasObjetivo(MedidasDTO medidasDTO, String CPF)
        {


            string sql = "INSERT INTO dbo.Medidas_Antropometricas_Objetivo (peso,altura,circunferencia_abdominal,IMC,ombro,peitoral,braco_esquerdo,braco_direito,coxa_esquerda,coxa_direita,biceps_direito,biceps_esquerdo,antebraco_esquerdo,antebraco_direito,panturrilha_esquerda,panturrilha_direita,quadril,gluteos,id_fk_cliente) " +
                "VALUES (" + medidasDTO.peso + "," + medidasDTO.altura + "," + medidasDTO.circunferenciaAbdominal + "," + medidasDTO.IMC + "," + medidasDTO.ombro + "," + medidasDTO.peitoral + "," + medidasDTO.bracoEsquerdo + "," + medidasDTO.bracoDireito + "," + medidasDTO.coxaEsquerda + "," + medidasDTO.coxaDireita + "," + medidasDTO.bicepsDireito + "," + medidasDTO.bicepsEsquerdo + "," + medidasDTO.antebracoEsquerdo + "," + medidasDTO.antebracoDireito + "," + medidasDTO.panturrilhaEsquerda + "," + medidasDTO.panturrilhaDireita + "," + medidasDTO.quadril + "," + medidasDTO.gluteos + "," + "(select id_pk_cliente from dbo.DadosPessoaisCliente where CPF=" + "'" + CPF + "'" + ")" + " )";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            int retorno = cmd.ExecuteNonQuery();

            return retorno;
        }

        public int deletaMedidasObjetivo(String CPF)
        {
            String retorno = "";
            string sql = "delete from dbo.Medidas_Antropometricas_Objetivo where  id_fk_cliente = (select id_pk_cliente from dbo.DadosPessoaisCliente where CPF=" + CPF + ");";

            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();

            int i = cmd.ExecuteNonQuery();
            return i;

        }

        public int alteraMedidasObjetivo(MedidasDTO medidasDTO, String CPF)
        {


            string sql = "UPDATE dbo.Medidas_Antropometricas_Objetivo SET  peso=" + medidasDTO.peso + "," + "altura=" + medidasDTO.altura + "," + "circunferencia_abdominal=" + medidasDTO.circunferenciaAbdominal + "," + "IMC=" + medidasDTO.IMC + "," + "ombro=" + medidasDTO.ombro + "," + "peitoral=" + medidasDTO.peitoral + "," + "braco_esquerdo=" + medidasDTO.bracoEsquerdo + "," + "braco_direito=" + medidasDTO.bracoDireito + "," + "coxa_esquerda=" + medidasDTO.coxaEsquerda + "," + "coxa_direita=" + medidasDTO.coxaDireita + "," + "biceps_esquerdo=" + medidasDTO.bicepsEsquerdo + "," + "biceps_direito=" + medidasDTO.bicepsDireito + "," + "antebraco_direito=" + medidasDTO.antebracoDireito + "," + "antebraco_esquerdo=" + medidasDTO.antebracoEsquerdo + "," + "panturrilha_esquerda=" + medidasDTO.panturrilhaEsquerda + "," + "panturrilha_direita=" + medidasDTO.panturrilhaDireita + "," + "quadril=" + medidasDTO.quadril + "," + "gluteos=" + medidasDTO.gluteos + "  where id_fk_cliente = (select id_pk_cliente from dbo.DadosPessoaisCliente where CPF=" + "'" + CPF + "'" + ");";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            int retorno = cmd.ExecuteNonQuery();

            return retorno;
        }

    }
}
