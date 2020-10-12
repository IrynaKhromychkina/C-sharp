namespace WorkWithDocument
{
    abstract class AbstractContent
    {
        public string content;

        public virtual string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Часть документа отсутствует.";
            }
            set
            {
                content = value;
            }
        }
                   
        public abstract void Show();
    }
}
