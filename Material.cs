using System;

namespace ObjetoTransferencia
{
    public class Material//vou encapsular
    {
        public int CadCod { get; set; }
        public string CadDesc { get; set; }
        public string Unid { get; set; }
        public decimal Valor { get; set; }
        public decimal Quant { get; set; }
        public decimal Total { get; set; }
        public DateTime MatData  { get; set; }
        public int FornecedorCod { get; set; }  //supplier
        public string FornecedorDesc { get; set; }
        public int Fase { get; set; } //

        /*Variável 
        private int CadCod;

        para dates public DateTime DataNasc  { get; set; } e colocar lá em cima using System;
        public Boolean Sexo { get; set; }
        //metodo para consulta 
        public int getCadCod()
        {
            return CadCod;
        }

        //metodo para alterar
        public void setCadCod(int cadCod)
        {
            CadCod = cadCod;
        }
        
         */


    }
}
