using System;

namespace DIO.Series
{
  public class Serie : EntidadeBase
  {
    private Genero genero { get; set; }
    private string titulo { get; set; }
    private string descricao { get; set; }
    private int ano { get; set; }
    private bool excluido { get; set; }

    public Serie(int id, Genero genero, string titulo, string descricao, int ano)
    {
      this.Id = id;
      this.genero = genero;
      this.titulo = titulo;
      this.descricao = descricao;
      this.ano = ano;
      this.excluido = false;
    }
    public override string ToString()
    {
      string retorno = "";
      retorno += "Gênero: " + this.genero + Environment.NewLine;
      retorno += "Titulo: " + this.titulo + Environment.NewLine;
      retorno += "Descrição: " + this.descricao + Environment.NewLine;
      retorno += "Ano de Início: " + this.ano + Environment.NewLine;
      retorno += "Excluido: " + this.excluido;
      return retorno;
    }
    public string retornaTitulo()
    {
      return this.titulo;
    }

    public int retornaId()
    {
      return this.Id;
    }
    public void Excluir()
    {
      this.excluido = true;
    }
    public bool retornaExcluido()
    {
      return this.excluido;
    }
  }
}