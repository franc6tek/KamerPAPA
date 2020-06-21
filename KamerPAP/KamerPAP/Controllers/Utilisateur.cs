using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KamerPAP.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Tools;

namespace KamerPAP.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Utilisateur : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Utilisateur>>> GetUtilisateur()
        {
            string ConnectionString = ConfigurationManager.GetAppSettings("ConnectionString");
            List<Models.Utilisateur> utilisateurs = new List<Models.Utilisateur>();

            using (SqlConnection sqlconn = new SqlConnection(ConnectionString))
            {
                sqlconn.Open();
                string sqlQery = "select * from [dbo].[utilisateur]";
                SqlCommand sqlComm = new SqlCommand(sqlQery, sqlconn);
                SqlDataReader sdr = sqlComm.ExecuteReader();
                while(sdr.Read())
                {
                    utilisateurs.Add(new Models.Utilisateur()
                    {
                        Id = Convert.ToInt32(sdr.GetValue(0)),
                        Email = sdr.GetValue(1).ToString(),
                        MotDePasse = sdr.GetValue(2).ToString(),
                        DateCreation = DateTime.Parse(sdr.GetValue(3).ToString()),
                        NomUtilisateur = sdr.GetValue(4).ToString()
                    }); 
                }
            }
            return Ok( utilisateurs);
        }
    }
}