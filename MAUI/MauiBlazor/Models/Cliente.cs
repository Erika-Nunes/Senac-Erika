using System;
using MauiBlazor.Models;

class Cliente{
    public int Id{get;set;}
    public string Nome{ get; set;}
    public string Email{ get; set;}
    public bool Ativo{ get; set;}

    public List <Item> Itens { get; set;}
    public Cliente(int id,string nome,string email,bool ativo,List <Item> itens){
        this.Id = id;
        this.Nome = nome;
        this.Email = email;
        this.Ativo =  ativo;
        this.Itens = itens;
    }
}
class Item
    { 
      public int Id{get;set;}
      public string Nome{get; set;} 
      public double Valor {get;set;} 
      public Item(int id, string nome, double valor){
            this.Id = id;
            this.Nome = nome;
            this.Valor = valor;

      }
    }

