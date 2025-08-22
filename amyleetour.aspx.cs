using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Sonuthapa
{
  public partial class amyleetour : System.Web.UI.Page
  {
            protected void btnSave_Click(object sender, EventArgs e)
            {
                string connStr = "Server=localhost;Database=dotnet_bca;Uid=root;Pwd=;";

                string title = txtTitle.Text;
                string description = txtDescription.Text;
                int duration;

                if (!int.TryParse(txtDuration.Text, out duration))
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Please enter a valid duration.";
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();

                        string query = "INSERT INTO tour_destination (Title, Description, Duration, CreatedDate) " +
                                       "VALUES (@title, @description, @duration, @createdDate)";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@duration", duration);
                        cmd.Parameters.AddWithValue("@createdDate", DateTime.Now.ToString("yyyy-MM-dd"));

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            lblMessage.ForeColor = System.Drawing.Color.Green;
                            lblMessage.Text = "Tour destination saved successfully!";
                            txtTitle.Text = txtDescription.Text = txtDuration.Text = "";
                        }
                        else
                        {
                            lblMessage.ForeColor = System.Drawing.Color.Red;
                            lblMessage.Text = "Failed to save destination.";
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "Error: " + ex.Message;
                    }
                }
            }
        }
    }