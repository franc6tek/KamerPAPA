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
    [Route("api/[controller]")]
    [ApiController]
    public class WebApiController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Utilisateur>>> GetUtilisateur()
        {
            string ConnectionString = ConfigurationManager.GetAppSettings("ConnectionString");
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            using (SqlConnection sqlconn = new SqlConnection(ConnectionString))
            {
                sqlconn.Open();
                string sqlQery = "select * from [dbo].[utilisateur]";
                SqlCommand sqlComm = new SqlCommand(sqlQery, sqlconn);
                SqlDataReader sdr = sqlComm.ExecuteReader();
                while(sdr.Read())
                {
                    utilisateurs.Add(new Utilisateur()
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