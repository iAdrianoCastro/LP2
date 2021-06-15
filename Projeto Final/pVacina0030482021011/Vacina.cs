using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace pVacina0030482021011
{
    class Vacina
    {
        private int idVacina;
        private string nomeVacina;
        private DateTime dataNascVacina;
        private string endVacina;
        private int cidadeIdVacina;
        private string cpfVacina;
        private string rgVacina;
        private DateTime dataVacina;
        private char tipoVacina;
        private char comorbidadeVacina;
        private char grupoprioriVacina;
        private int enfermeiroIdEnfermeiro;


        //properties
        public int IdVacina
        {
            get
            {
                return idVacina;
            }
            set
            {
                idVacina = value;
            }
        }

        public string NomeVacina
        {
            get
            {
                return nomeVacina;
            }
            set
            {
                nomeVacina = value;
            }
        }

        public DateTime DataNascVacina
        {
            get
            {
                return dataNascVacina;
            }
            set
            {
                dataNascVacina = value;
            }
        }


        public string EndVacina
        {
            get
            {
                return endVacina;
            }
            set
            {
                endVacina = value;
            }
        }

        public int CidadeIdVacina
        {
            get
            {
                return cidadeIdVacina;
            }
            set
            {
                cidadeIdVacina = value;
            }
        }

        public string CpfVacina
        {
            get
            {
                return cpfVacina;
            }
            set
            {
                cpfVacina = value;
            }
        }

        public string RgVacina
        {
            get
            {
                return rgVacina;
            }
            set
            {
                rgVacina = value;
            }
        }

        public DateTime DataVacina
        {
            get
            {
                return dataVacina;
            }
            set
            {
                dataVacina = value;
            }
        }

        public char TipoVacina
        {
            get
            {
                return tipoVacina;
            }
            set
            {
                tipoVacina = value;
            }
        }

        public char ComorbidadeVacina
        {
            get
            {
                return comorbidadeVacina;
            }
            set
            {
                comorbidadeVacina = value;
            }
        }

        public char GrupoPrioriVacina
        {
            get
            {
                return grupoprioriVacina;
            }
            set
            {
                grupoprioriVacina = value;
            }
        }

        public int EnfermeiroIdEnfermeiro
        {
            get
            {
                return enfermeiroIdEnfermeiro;
            }
            set
            {
                enfermeiroIdEnfermeiro = value;
            }
        }


        //metodos
        public DataTable Listar()
        {
            SqlDataAdapter daVacina;

            DataTable dtVacina = new DataTable();

            try
            {
                daVacina = new SqlDataAdapter("SELECT * FROM Vacina", frmPrincipal.conexao);

                daVacina.Fill(dtVacina);
                daVacina.FillSchema(dtVacina, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtVacina;
        }

        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;
                mycommand = new SqlCommand("INSERT INTO VACINA VALUES (@nomeVacina, @dataNascVacina, @endVacina, @cidadeIdVacina, @cpfVacina, @rgVacina, @dataVacina, @tipoVacina," +
                "@comorbidadeVacina, @grupoprioriVacina, @enfermeiroIdEnfermeiro)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nomeVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataNascVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@endVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeIdVacina", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@cpfVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@rgVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@tipoVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@comorbidadeVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@grupoprioriVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@enfermeiroIdEnfermeiro", SqlDbType.Int));


                mycommand.Parameters["@nomeVacina"].Value = NomeVacina;
                mycommand.Parameters["@dataNascVacina"].Value = DataNascVacina;
                mycommand.Parameters["@endVacina"].Value = EndVacina;
                mycommand.Parameters["@cidadeidVacina"].Value = CidadeIdVacina;
                mycommand.Parameters["@cpfVacina"].Value = CpfVacina;
                mycommand.Parameters["@rgVacina"].Value = RgVacina;
                mycommand.Parameters["@dataVacina"].Value = DataVacina;
                mycommand.Parameters["@tipoVacina"].Value = TipoVacina;
                mycommand.Parameters["@comorbidadeVacina"].Value = ComorbidadeVacina;
                mycommand.Parameters["@grupoprioriVacina"].Value = GrupoPrioriVacina;
                mycommand.Parameters["@enfermeiroIdEnfermeiro"].Value = EnfermeiroIdEnfermeiro;


                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }


        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("UPDATE VACINA SET nome_vacina=@nomeVacina,datanasc_vacina=@dataNascVacina," +
               "end_vacina=@endVacina,cidade_id_cidade=@cidadeIdcidade,cpf_vacina=@cpfVacina,rg_vacina=@rgVacina, data_vacina=@dataVacina," +
               "tipo_vacina=@tipoVacina,comorbidade_vacina=@comorbidadeVacina,grupopriori_vacina=@grupoprioriVacina,enfermeiro_id_enfermeiro=@enfermeiroIdenfermeiro" +
               " where id_vacina=@idVacina",
               frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idVacina", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nomeVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataNascVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@endVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeIdcidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@cpfVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@rgVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@tipoVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@comorbidadeVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@grupoprioriVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@enfermeiroIdenfermeiro", SqlDbType.Int));

                mycommand.Parameters["@idVacina"].Value = IdVacina;
                mycommand.Parameters["@nomeVacina"].Value = NomeVacina;
                mycommand.Parameters["@dataNascVacina"].Value = DataNascVacina;
                mycommand.Parameters["@endVacina"].Value = EndVacina;
                mycommand.Parameters["@cidadeIdcidade"].Value = CidadeIdVacina;
                mycommand.Parameters["@cpfVacina"].Value = CpfVacina;
                mycommand.Parameters["@rgVacina"].Value = RgVacina;
                mycommand.Parameters["@dataVacina"].Value = DataVacina;
                mycommand.Parameters["@tipoVacina"].Value = TipoVacina;
                mycommand.Parameters["@comorbidadeVacina"].Value = ComorbidadeVacina;
                mycommand.Parameters["@grupoprioriVacina"].Value = GrupoPrioriVacina;
                mycommand.Parameters["@enfermeiroIdenfermeiro"].Value = EnfermeiroIdEnfermeiro;

                retorno = mycommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }


        public int Excluir()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM VACINA where id_vacina=@idVacina",
                frmPrincipal.conexao);


                mycommand.Parameters.Add(new SqlParameter("@idVacina", SqlDbType.Int));

                mycommand.Parameters["@idVacina"].Value = IdVacina;

                retorno = mycommand.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }



    }
}
