using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multichat
{
    public partial class Crear_grupo : Form
    {
        private string userList;
        private Cliente cliente;
        public Button bt_create { get { return btn_create; } }


        public Crear_grupo(string user_list, Cliente client)
        {
            InitializeComponent();
            userList = user_list;
            this.cliente = client;
            InitializeCheckedListBox();
        }

        private void InitializeCheckedListBox()
        {
            string[] users = userList.Split(',');

            foreach (string user in users)
            {
                group_users.Items.Add(user);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string g_name = txt_groupname.Text + ":";
            List<string> selectedUsers = new List<string>();

            for (int i = 0; i < group_users.Items.Count; i++)
            {
                if (group_users.GetItemChecked(i))
                {
                    selectedUsers.Add(group_users.Items[i].ToString().Trim());
                }
            }

            string userList = string.Join(",", selectedUsers);

            MessageBox.Show("Nombre del grupo: " + g_name + "\nUsuarios seleccionados: " + userList);
            cliente.SendCreateGroupMessage(g_name, userList);
        }



    }
}
