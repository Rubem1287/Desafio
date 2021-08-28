﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Domain.Entittes
{
    public sealed class Usuario
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public DateTime BirthDay { get; private set; }
        public int Phone { get; private set; }
        public int CellPhone { get; private set; }
        public string Email { get; private set; }
        public string Adress { get; private set; }
        public string Photo { get; private set; }
        public ICollection<Tarefas> ListTarefas { get; set; }
        public int TarefasId { get; private set; }
        public Tarefas Tarefas { get; private set; }

        public Usuario(int id, string name, string password, DateTime birthday, int phone, int cellphone, string email, string adress, string photo)
        {
            Id = id;
            Name = name;
            Password = password;
            BirthDay = birthday;
            Phone = phone;
            CellPhone = cellphone;
            Email = email;
            Adress = adress;
            Phone = phone;
        }

        public Usuario(string name, string password, DateTime birthday, int phone, int cellphone, string email, string adress, string photo)
        {
            ValidateUsuario(name, password, birthday, phone, cellphone, email, adress, photo);
            //Name = name;
            //Password = password;
            //BirthDay = birthday;
            //Phone = phone;
            //CellPhone = cellphone;
            //Email = email;
            //Adress = adress;
            //Phone = phone;
            //Photo = photo;
        }

        public Usuario(Tarefas tarefas, int tarefasId)
        {
            Tarefas = tarefas;
            TarefasId = tarefasId;
        }

        private void ValidateUsuario(string name, string password, DateTime birthday, int phone, int cellphone, string email, string adress, string photo)
        {

        }
    }
}