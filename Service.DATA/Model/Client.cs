namespace Service.DATA.Model
{
    //таблица откуда будет браться ИИН, нужно поменять(Как пример) 
    public class Client
    {
        public int Id { get; set; }
        public string? IIN { get; set; }
        public string? FIO { get; set; }
        public bool? Send {get; set; }      
    }
}
