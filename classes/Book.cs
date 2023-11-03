namespace classes
{
    class Book
    {
        // Constructor
        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        // Properties - private
        string _name;
        string _author;
        int _pagecount;

        // Methods
        public string GetDescription()
        {
        return $"{_name} by {_author}, {_pagecount} pages.";
        }

    }
}