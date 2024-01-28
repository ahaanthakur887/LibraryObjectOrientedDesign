namespace LibraryOOP
{
    public  class Books
    {
        // Fields
        private bool Availability = true;

        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationDate { get; set; }

        // Constructor
        public Books(string title, string author, int publicationDate)
        {
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
        }

        // Methods
        public string BookInfo()
        {
            return $"Title is : {Title}, Author is {Author}, Publication date is {PublicationDate}.";
        }
    }
}