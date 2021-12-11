using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RE_Cafeteria.Modelo;

namespace RE_Cafeteria.Controlador
{
    class ESUsuario
    {

        private int id;
        private string nombre;
        private string apellidos;
        private string user;
        private string pass;
        private bool estado;

        public ESUsuario(int id, string nombre, string apellidos, string user, string pass, bool estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.user = user;
            this.pass = pass;
            this.estado = estado;
        }

        public ESUsuario(string nombre, string apellidos, string user, string pass, bool estado)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.user = user;
            this.pass = pass;
            this.estado = estado;
        }

        public ESUsuario() { 
        
        }

        public void insertarusuario() {
            BDUsuario nuevo = new BDUsuario();
            nuevo.insertar(this);
        
        }

        public void eliminarusuario(int id) {
            BDUsuario eliminar = new BDUsuario();
            eliminar.eliminar(id);
        }

        public void modificarusuario() {
            BDUsuario mod = new BDUsuario();
            mod.modificar(this);

        }



        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public bool Estado { get => estado; set => estado = value; }
    }


}
