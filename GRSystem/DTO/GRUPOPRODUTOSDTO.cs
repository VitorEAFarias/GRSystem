namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class GRUPOPRODUTOSDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAVE"></param>
        /// <param name="CHAVE_LINHA"></param>
        /// <param name="GRUPO"></param>
        public GRUPOPRODUTOSDTO(int CHAVE, int CHAVE_LINHA, string GRUPO)
        {
            this.CHAVE = CHAVE;            
            this.CHAVE_LINHA = CHAVE_LINHA;
            this.GRUPO = GRUPO;
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_LINHA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string GRUPO { get; private set; }
    }
}
