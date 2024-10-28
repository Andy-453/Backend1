namespace backendjuego.Model
{

    //posible eliminacion 
    public class Documents
    {
        public int DocumentId { get; set; }
        public bool IsProtected { get; set; }
        public bool IsShared { get; set; }
        public string Address { get; set; }
        public string TypeDocument { get; set; }
        public string DocumentName { get; set; }
        public long DocumentSize { get; set; }
        public byte[] DocumentContent { get; set; }
        public bool IsDeleted { get; set; } = false;
        public ICollection<DocumentsHistorics> DocumentsHistorics { get; set; }
    }
}
