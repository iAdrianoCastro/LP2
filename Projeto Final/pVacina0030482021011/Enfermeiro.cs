﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace pVacina0030482021011
{
    class Enfermeiro
    {

        //atributos
        private int idEnfermeiro;
        private string nomeEnfermeiro;
        private string corenEnfermeiro;

        //properties
        public int IdEnfermeiro
        {
            get
            {
                return idEnfermeiro;
            }
            set
            {
                idEnfermeiro = value;
            }
        }


        public string NomeEnfermeiro
        {
            get
            {
                return nomeEnfermeiro;
            }
            set
            {
                nomeEnfermeiro = value;
            }
        }



        public string CorenEnfermeiro
        {
            get
            {
                return corenEnfermeiro;
            }
            set
            {
                corenEnfermeiro = value;
            }
        }


        public DataTable Listar()
        {
            SqlDataAdapter daEnfermeiro;

            DataTable dtEnfermeiro = new DataTable();

            try
            {
                daEnfermeiro = new SqlDataAdapter("SELECT * FROM Enfermeiro", frmPrincipal.conexao);

                daEnfermeiro.Fill(dtEnfermeiro);
                daEnfermeiro.FillSchema(dtEnfermeiro, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtEnfermeiro;
        }





    }
}
