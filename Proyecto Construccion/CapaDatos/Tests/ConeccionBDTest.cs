using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.Data.SqlClient;

namespace CapaDatos.Tests
{
    [TestFixture]
    internal class ConeccionBDTest
    {
        [Test]
        public void Valida_ConeccionCorrecta_BD()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=dbProyectoCS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            Assert.That(conn.State, Is.EqualTo(System.Data.ConnectionState.Open), "La conección debería estar abierta.");
        }
    }
}
