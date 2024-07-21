using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public partial class DayPageViewModel : BaseViewModel
    {
        private List<string> books = new List<string>
        {
            "To Kill a Mockingbird",
            "Sapiens: A Brief History of Humankind",
            "1984",
            "The Catcher in the Rye",
            "The Immortal Life of Henrietta Lacks",
            "The Great Gatsby",
            "Pride and Prejudice",
            "The Hobbit",
            "Thinking, Fast and Slow",
            "The Road"
        };

        private List<string> genres = new List<string>
        {
            "Fiction, Classic",
            "Non-fiction, History",
            "Fiction, Dystopian",
            "Fiction, Coming-of-Age",
            "Non-fiction, Biography, Science",
            "Fiction, Classic",
            "Fiction, Romance, Classic",
            "Fiction, Fantasy",
            "Non-fiction, Psychology",
            "Fiction, Post-apocalyptic"
        };

        private List<string> descriptions = new List<string>
        {
            "A novel set in the American South during the 1930s, focusing on themes of racial injustice and moral growth, seen through the eyes of young Scout Finch.",
            "This book explores the history of humanity from the emergence of Homo sapiens in the Stone Age to the political and technological revolutions of the 21st century.",
            "A dystopian novel set in a totalitarian society ruled by Big Brother, exploring themes of surveillance, censorship, and individuality.",
            "The novel follows the experiences of 16-year-old Holden Caulfield in New York City as he grapples with complex issues of identity, belonging, and alienation.",
            "The book tells the story of Henrietta Lacks and the immortal cell line, known as HeLa, that came from her cervical cancer cells in 1951, highlighting ethical issues in medical research and personal stories intertwined with scientific discovery.",
            "A novel about the American dream and the disillusionment of the Jazz Age, following the mysterious Jay Gatsby and his unrequited love for Daisy Buchanan.",
            "A classic novel that explores themes of love, reputation, and class in early 19th-century England through the relationship between Elizabeth Bennet and Mr. Darcy.",
            "A fantasy novel that follows the adventures of Bilbo Baggins, a hobbit who is reluctantly drawn into a quest to reclaim a treasure guarded by the dragon Smaug.",
            "A book that delves into the two systems of thought that drive our decisions: the fast, intuitive, and emotional system, and the slow, deliberate, and logical system.",
            "A post-apocalyptic novel that tells the story of a father and his young son as they journey across a desolate landscape, struggling to survive and retain their humanity."
        };

        private List<string> imageLinks = new List<string>
        {
            "https://cdn.discordapp.com/attachments/1248755784905527346/1264708978768609402/image.png?ex=669edb85&is=669d8a05&hm=e201ec86269556b56e7a44b6ea760c0fd7bdaa78d6f1bfee2b3bd289c0174eb7&", // To Kill a Mockingbird
            "https://cdn.discordapp.com/attachments/1248755784905527346/1264709096020508745/image.png?ex=669edba1&is=669d8a21&hm=13c7c77401947996c7c4a801a13602344f68b7ea65a2da0dd2d99f960efeb2fa&", // Sapiens: A Brief History of Humankind
            "https://cdn.discordapp.com/attachments/1248755784905527346/1264709420185681951/image.png?ex=669edbee&is=669d8a6e&hm=b0c7a75e7122eb1092ea1e190c3a85debbe0dac5467a5a44d979e5ed14cc2538&", // 1984
            "https://cdn.discordapp.com/attachments/1248755784905527346/1264709682573082665/image.png?ex=669edc2d&is=669d8aad&hm=f4cc8bfc4fac7b54327eb25b4b9c12fe95151f2d0821ac7b8ce374b85b4c7c5d&", // The Catcher in the Rye
            "https://cdn.discordapp.com/attachments/1248755784905527346/1264709882808897629/image.png?ex=669edc5d&is=669d8add&hm=ff6e05a19f3eaee66a1d161d447a0066fcd3b6a5719a45e25bd1f5d44572ff2b&", // The Immortal Life of Henrietta Lacks
            "https://cdn.discordapp.com/attachments/1248755784905527346/1264710093736247316/image.png?ex=669edc8f&is=669d8b0f&hm=acfaf4384fd60181760dcf788e70e1d4c99fb1e6274d3a4565551f88a092c60e&", // The Great Gatsby
            "https://cdn.discordapp.com/attachments/1248755784905527346/1264710249839988798/image.png?ex=669edcb4&is=669d8b34&hm=6ba6ccf956aa56b9e8a9cc50224a7f3e11454bfc1e66d7eef133b383db6f1b41&", // Pride and Prejudice
            "https://cdn.discordapp.com/attachments/1248755784905527346/1264710757854089256/image.png?ex=669edd2d&is=669d8bad&hm=e8ed58c02f6b0eedd0f0d4bb60082b6519324989535a634bc598800badf08a5a&", // The Hobbit
            "https://cdn.discordapp.com/attachments/1248755784905527346/1264710895989424309/image.png?ex=669edd4e&is=669d8bce&hm=1d79cdc7219f642dd320614f219ef802d45705946a0da58eaf3c8f3be135f15a&", // Thinking, Fast and Slow
            "https://cdn.discordapp.com/attachments/1248755784905527346/1264711113673805934/image.png?ex=669edd82&is=669d8c02&hm=62680011b14e3de1f8797f013020fb9fc7bdea576863fa9c54761fab0a13e081&"  // The Road
        };

        private List<string> authors = new List<string>
        {
            "Harper Lee",
            "Yuval Noah Harari",
            "George Orwell",
            "J.D Salinger",
            "Rebecca Skloot",
            "F. Scott Fitzgerald",
            "Jane Austen",
            "J.R.R. Tolkien",
            "Daniel Kahneman",
            "Cormac McCarthy"
        };

        static Random rnd = new Random();

        private int randInt = rnd.Next(1, 10);

        public string Book
        {
            get => books[randInt];
        }

        public string Genre
        {
            get => genres[randInt];
        }

        public string Description
        {
            get => descriptions[randInt];
        }

        public string Image
        {
            get => imageLinks[randInt];
        }

        public string Author
        {
            get => authors[randInt];
        }
    }
}


