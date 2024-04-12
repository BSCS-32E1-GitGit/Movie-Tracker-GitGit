using Microsoft.AspNetCore.Mvc;
using movie_tracker.Models;
using System.Linq;

namespace movie_tracker.Controllers
{
    public class MovieController : Controller
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie
{
    Id = 1,
    Title = "DAMSEL",
    Director = "Juan Carlos Fresnadillo",
    Cast = new List<string> {"Millie Bobby Brown", "Ray Winstone", "Robin Wright", "Angela Bassett", "Nick Robinson", "Shoreh Aghdashloo" },
    Genre = "Action, Adventure movies, US movies ",
    ReleaseDate = new DateTime(2024, 3, 8),
    MovieInfo = "A young woman’s marriage to a charming prince turns into a fierce fight for survival when she’s offered up as a sacrifice to a fire breathing dragon",
    ImageUrl = "/image/m1.png"
},
new Movie
{
    Id = 2,
    Title = "CODE 8 II",
    Director = "Jeff Chan",
    Cast = new List<string> {"Robbie Amell", "Stephen Amell", "Alex Mallari Jr.", "Sirena Gulamgaus", "Jean Yoon", "Aaron Abrams" },
    Genre = "Sci-fi movies",
    ReleaseDate = new DateTime(2024, 2, 8),
    MovieInfo = "In a city where people with powers are policed and oppressed, an ex-criminal must turn to a drug lord he despises to protect a teen from corrupt cops",
    ImageUrl = "/image/m2.png"
},
new Movie
{
    Id = 3,
    Title = "A family affair",
    Director = "Richard LaGravenese",
    Cast = new List<string> {"Nicole Kidman", "Zac Efron", "Joey King", "Liza Koshy", "Kathy Bates" },
    Genre = "Romance, Comedy, Drama",
    ReleaseDate = DateTime.MinValue,
    MovieInfo = "A surprising romance kicks off comic consequences for a young woman (Joey King), her mother (Nicole Kidman), and her movie star boss (Zac Efron) as they face the complications of love, sex, and identity",
    ImageUrl = "/image/m3.png"
},
new Movie
{
    Id = 4,
    Title = "Atlas",
    Director = "Brad Peyton",
    Cast = new List<string> {"Jennifer Lopez", "Simu Liu", "Sterling K. Brown", "Gregory J. Cohan", "Abraham Popoola", "Lana Parrilla", "Mark Strong" },
    Genre = "Action, Sci Fi",
    ReleaseDate = DateTime.MinValue,
    MovieInfo = "Atlas Shepherd (Jennifer Lopez), a brilliant but misanthropic data analyst with a deep distrust of artificial intelligence, joins a mission to capture a renegade robot with whom she shares a mysterious past. But when plans go awry, her only hope of saving the future of humanity from AI is to trust it",
    ImageUrl = "/image/m4.png"
},
new Movie
{
    Id = 5,
    Title = "The Beautiful Game",
    Director = "Thea Sharrock",
    Cast = new List<string> {"Bill Nighy", "Micheal Ward", "Susan Wokoma", "Callum Scott Howells", "Kit Young", "Sheyi Cole", "Tom Vaughan-Lawlor", "Robin Nazari", "Aoi Okuyama", "Cristina Rodlo", "Tadashi Watanabe", "Kazuhiro Muroyama", "Valeria Golino" },
    Genre = "Drama Sports",
    ReleaseDate = new DateTime(2024, 3, 29),
    MovieInfo = "As an English football squad heads to Rome for the homeless world cup, their talented new player must let go of his past and learn to be part of a team",
    ImageUrl = "/image/m5.png"
},
new Movie
{
    Id = 6,
    Title = "Badland Hunters",
    Director = "Heo Myeong haeng",
    Cast = new List<string> {"Don lee", "Lee hee jun", "Lee jun young", "Roh Jeong eui", "An Ji hye", "Park ji hun", "Jang Young nam", "Park hyo joon", "Seong byeong suk", "Jeong Young ju" },
    Genre = "Korean, Action & Adventure Movies",
    ReleaseDate = new DateTime(2024, 1, 26),
    MovieInfo = "The film is a sequel to Concrete Utopia and takes up the story post-earthquake transformation of Seoul into an apocalyptic wasteland, where everything from law and order to civilization has collapsed",
    ImageUrl = "/image/m6.png"
},
new Movie
{
    Id = 7,
    Title = "60 Minutes",
    Director = "Oliver Kienle",
    Cast = new List<string> {"Emilio Sakraya", "Dennis Mojen", "Livia Matthes", "Marie Mouroum", "Floria Schmidtke", "Morik Heydo", "Paul Wollin", "Aristo Luis" },
    Genre = "German, Sports Movies, Martial Arts",
    ReleaseDate = new DateTime(2024, 1, 19),
    MovieInfo = "The story of how a mixed martial arts fighter named Octavio desperately leaves an important match to not lose his daughter's custody. In doing so, he makes an enemy out of a group of menacing criminals",
    ImageUrl = "/image/m7.png"
},
new Movie
{
    Id = 8,
    Title = "Murder Mubarak",
    Director = "Homi Adajania",
    Cast = new List<string> {"Sara Ali Khan", "Vijay Varma", "Karisma Kapoor", "Dimple Kapadia", "Tisca Chopra", "Sanjay Kapoor", "Pankaj Tripathi", "Suhail Nayyar", "Deven Bhojani", "Tara Alisha Berry" },
    Genre = "Comedy, Mystery, Thriller",
    ReleaseDate = new DateTime(2024, 3, 14),
    MovieInfo = "During a murder investigation, a non-traditional police officer turns a spotlight on an array of suspects. He steps into their world as an outsider, only to find there is so much more than what meets the eye",
    ImageUrl = "/image/m8.png"
},
new Movie
{
    Id = 9,
    Title = "Orion and the dark",
    Director = "Sean Charmatz",
    Cast = new List<string> {"Animation" },
    Genre = "Kids & family, Comedy, Animation",
    ReleaseDate = new DateTime(2024, 2, 2),
    MovieInfo = "A boy with an active imagination faces his fears on an unforgettable journey through the night with his new friend: a giant, smiling creature named dark",
    ImageUrl = "/image/m9.png"
},
new Movie
{
    Id = 10,
    Title = "Despicable Me 4",
    Director = "Mike Mitchell, Stephanie Stine",
    Cast = new List<string> {"Animation" },
    Genre = "Comedy",
    ReleaseDate = new DateTime(2024, 6, 1),
    MovieInfo = "Despicable Me 4 will see Gru adapting to family life with his adopted daughters, wife Lucy (Kristen Wiig) and new son Gru Jr., a rare state of calm thrown into chaos when Maxime Le Mal (Ferrell) breaks out of prison intent on targeting him and the brood",
    ImageUrl = "/image/m10.png"
},
new Movie
{
    Id = 11,
    Title = "Ballerina",
    Director = "Lee Chung-hyun",
    Cast = new List<string> {"Jeon Jong-seo", "Kim Ji-hoon", "Park Yu-rim", "Park Hyung-soo" },
    Genre = "Action Thriller",
    ReleaseDate = new DateTime(2023, 10, 6),
    MovieInfo = "Grieving the loss of a best friend she couldn't protect, an ex-bodyguard sets out to fulfill her dear friend's last wish: sweet revenge.",
    ImageUrl = "/image/m11.jpg"
},
new Movie
{
    Id = 12,
    Title = "Nowhere",
    Director = "Albert Pintó",
    Cast = new List<string> {"Anna Castillo", "Miguel Ruiz" },
    Genre = "Thriller/Drama",
    ReleaseDate = new DateTime(2023, 9, 29),
    MovieInfo = "A young pregnant woman named Mia escapes from a country at war by hiding in a maritime container aboard a cargo ship. After a violent storm, Mia gives birth to her child while lost at sea, where she must fight to survive.",
    ImageUrl = "/image/m12.jpg"
},
new Movie
{
    Id = 13,
    Title = "After Everything",
    Director = "Castille Landon",
    Cast = new List<string> {"Hero Fiennes Tiffin", "Josephine Langford", "Louise Lombard", "Stephen Moyer", "Mimi Keene" },
    Genre = "Drama Romance",
    ReleaseDate = new DateTime(2023, 9, 13),
    MovieInfo = "After breaking up with his true love, best-selling author Hardin Scott travels to Portugal in an attempt to make amends for his past behavior.",
    ImageUrl = "/image/m13.jpg"
},
new Movie
{
    Id = 14,
    Title = "Insidious The Red Door",
    Director = "Patrick Wilson",
    Cast = new List<string> {"Ty Simpkins", "Patrick Wilson", "Rose Byrne", "Sinclair Daniel", "Hiam Abbass", "Andrew Astor", "Lin Shaye", "Steve Coulter" },
    Genre = "Horror, Mystery & Thriller",
    ReleaseDate = new DateTime(2023, 7, 7),
    MovieInfo = "In Insidious: The Red Door, the horror franchise's original cast returns for the final chapter of the Lambert family's terrifying saga. To put their demons to rest once and for all, Josh (Patrick Wilson) and a college-aged Dalton (Ty Simpkins) must go deeper into The Further than ever before, facing their family's dark past and a host of new and more horrifying terrors that lurk behind the red door.",
    ImageUrl = "/image/m14.jpg"
},
new Movie
{
    Id = 15,
    Title = "Extraction 2",
    Director = "Sam Hargrave",
    Cast = new List<string> {"Chris Hemsworth", "Golshifteh Farahani", "Tornike Gogrichiani", "Adan Bessa", "Olga Kurylenko" },
    Genre = "Action, Crime & Thriller",
    ReleaseDate = new DateTime(2023, 6, 9),
    MovieInfo = "After barely surviving his grievous wounds from his mission in Dhaka, Bangladesh, Tyler Rake is back, and his team is ready to take on their next mission.",
    ImageUrl = "/image/m15.jpg"
},
new Movie
{
    Id = 16,
    Title = "John Wick 4",
    Director = "Chad Stahelski",
    Cast = new List<string> {"Keanu Reeves", "Laurence Fishburne", "George Georgiou", "Lance Reddick" },
    Genre = "Action, Mystery & Thriller",
    ReleaseDate = new DateTime(2023, 3, 24),
    MovieInfo = "John Wick uncovers a path to defeating The High Table. But before he can earn his freedom, Wick must face off against a new enemy with powerful alliances across the globe and forces that turn old friends into foes.",
    ImageUrl = "/image/m16.jpg"
},
new Movie
{
    Id = 17,
    Title = "A Very Good Girl",
    Director = "Petersen Vargas",
    Cast = new List<string> {"Dolly De Leon", "Kathryn Bernardo", "Kaori Oinuma", "Jake Ejercito", "Gillian Vicencio", "Chienna Filomeno", "Donna Cariaga" },
    Genre = "Comedy, Drama, Mystery & Thriller",
    ReleaseDate = new DateTime(2023, 10, 6),
    MovieInfo = "After a heartless firing triggers a chain of unfortunate events, Philo plots a meticulous revenge against retail mogul, Mother Molly, aiming to dismantle her empire and seize the ultimate payback. This time, there is no mercy.",
    ImageUrl = "/image/m17.jpg"
},
new Movie
{
    Id = 18,
    Title = "Five Nights at Freddy's",
    Director = "Emma Tammi",
    Cast = new List<string> {"Josh Hutcherson", "Elizabeth Lail", "Matthew Liliard", "MatPat", "Piper Rubio", "Kat Conner Sterling" },
    Genre = "Horror, Mystery & Thriller",
    ReleaseDate = new DateTime(2023, 10, 7),
    MovieInfo = "A troubled security guard begins working at Freddy Fazbear's Pizzeria. While spending his first night on the job, he realizes the late shift at Freddy's won't be so easy to make it through.",
    ImageUrl = "/image/m18.jpg"
},
new Movie
{
    Id = 19,
    Title = "The Nun II",
    Director = "Michael Chaves",
    Cast = new List<string> {"Taissa Farmiga", "Anna Popplewell", "Bonnie Aarons", "Storm Reid", "Jonas Bloquet", "Vera Farmiga", "Katelyn Rose Downey" },
    Genre = "Horror, Mystery & Thriller",
    ReleaseDate = new DateTime(2023, 9, 8),
    MovieInfo = "1956 -- France. A priest is murdered. An evil is spreading. The sequel to the worldwide smash hit follows Sister Irene as she once again comes face-to-face with Valak, the demon nun.",
    ImageUrl = "/image/m19.jpg"
},
new Movie
{
    Id = 20,
    Title = "Fast X",
    Director = "Louis Laterrier",
    Cast = new List<string> {"Vin Diesel", "Jason Momoa", "Alan Ritchson", "Rita Moreno", "Michelle Rodriguez", "Drie Larson", "Sung Kang" },
    Genre = "Action, Adventure",
    ReleaseDate = new DateTime(2023, 5, 19),
    MovieInfo = "Over many missions and against impossible odds, Dom Toretto and his family have outsmarted and outdriven every foe in their path. Now, they must confront the most lethal opponent they've ever faced.",
    ImageUrl = "/image/m20.jpg"
},
new Movie
{
    Id = 21,
    Title = "Black Phanter Wakanada Forever",
    Director = "Ryan Coogler",
    Cast = new List<string> {"Chadwick Boseman", "Lupita Nyong'o", "Danai Gurira", "Letitia Wright", "Winston Duke", "Angela Bassett", "Martin Freeman" },
    Genre = "Action Adventure Drama",
    ReleaseDate = new DateTime(2022, 11, 11),
    MovieInfo = "Warriors must protect Wakanda from intervening world powers in the wake of King T'Challa's death",
    ImageUrl = "/image/m21.jpg"
},
new Movie
{
    Id = 22,
    Title = "Thor Love and Thunder",
    Director = "Taika Waititi",
    Cast = new List<string> {"Chris Hemsworth", "Natalie Portman", "Tessa Thompson", "Christian Bale", "Chris Pratt", "Jaimie Alexander" },
    Genre = "Action-Adventure, Comedy, Fantasy, Romance, Superhero",
    ReleaseDate = new DateTime(2022, 7, 8),
    MovieInfo = "Thor, King Valkyrie, Korg and Jane Foster battle a galactic killer known as Gorr the God Butcher",
    ImageUrl = "/image/m22.jpg"
},
new Movie
{
    Id = 23,
    Title = "Doctor Strange",
    Director = "Sam Raimi",
    Cast = new List<string> {"Benedict Cumberbatch", "Elizabeth Olsen", "Benedict Wong", "Chiwetel Ejiofor", "Xochitl Gomez" },
    Genre = "Action, Adventure, Fantasy",
    ReleaseDate = new DateTime(2022, 5, 6),
    MovieInfo = "Dr. Stephen Strange travels into the multiverse to face a mysterious new adversary",
    ImageUrl = "/image/m23.jpg"
},
new Movie
{
    Id = 24,
    Title = "Halloween Ends (2022)",
    Director = "David Gordon Green",
    Cast = new List<string> {"Jamie Lee Curtis", "Andi Matichak", "Judy Greer" },
    Genre = "Horror, Thriller",
    ReleaseDate = new DateTime(2022, 10, 14),
    MovieInfo = "A cascade of violence and terror forces Laurie Strode to confront the evil she can't control",
    ImageUrl = "/image/m24.jpg"
},
new Movie
{
    Id = 25,
    Title = "Avatar: The Way of Water",
    Director = "James Cameron",
    Cast = new List<string> {"Sam Worthington", "Zoe Saldana", "Sigourney Weaver", "Stephen Lang", "Kate Winslet" },
    Genre = "Action-Adventure, Fantasy",
    ReleaseDate = new DateTime(2022, 12, 16),
    MovieInfo = "When a familiar threat resurfaces, Jake and Neytiri must protect their children and their planet",
    ImageUrl = "/image/m25.jpg"
},
new Movie
{
    Id = 26,
    Title = "Jurassic World Dominion",
    Director = "Colin Trevorrow",
    Cast = new List<string> {"Chris Pratt", "Bryce Dallas Howard", "Sam Neill", "Laura Dern", "Jeff Goldblum" },
    Genre = "Action Adventure Sci-Fi Thriller",
    ReleaseDate = new DateTime(2022, 6, 10),
    MovieInfo = "The future of mankind hangs in the balance as dinosaurs now live and hunt alongside humans",
    ImageUrl = "/image/m26.jpg"
},
new Movie
{
    Id = 27,
    Title = "The Batman",
    Director = "Matt Reeves",
    Cast = new List<string> {"Robert Pattinson", "Zoë Kravitz", "Paul Dano", "Jeffrey Wright", "Colin Farrell", "Andy Serkis" },
    Genre = "Action, Adventure, Crime & Gangster",
    ReleaseDate = new DateTime(2022, 3, 2),
    MovieInfo = "Batman ventures into Gotham City's underworld when a killer leaves behind a trail of cryptic clues",
    ImageUrl = "/image/m27.jpg"
},
new Movie
{
    Id = 28,
    Title = "Scream (I) (2022)",
    Director = "Matt Bettinelli-Olpin, Tyler Gillett",
    Cast = new List<string> {"Neve Campbell", "Courteney Cox", "David Arquette", "Melissa Barrera", "Jenna Ortega" },
    Genre = "Horror , Thriller",
    ReleaseDate = new DateTime(2022, 2, 2),
    MovieInfo = "A new killer dons the Ghostface mask and begins targeting a group of teenagers to resurrect secrets",
    ImageUrl = "/image/m28.jpg"
},
new Movie
{
    Id = 29,
    Title = "Uncharted (2022)",
    Director = "Ruben Fleischer",
    Cast = new List<string> {"Tom Holland", "Mark Wahlberg", "Antonio Banderas", "Sophia Ali", "Matt Smith" },
    Genre = "Action Adventure",
    ReleaseDate = new DateTime(2022, 2, 18),
    MovieInfo = "Two treasure hunters race against time to recover Ferdinand Magellan's 500-year-old lost fortune",
    ImageUrl = "/image/m29.jpg"
},
new Movie
{
    Id = 30,
    Title = "Morbius (2022)",
    Director = "Daniel Espinosa",
    Cast = new List<string> {"Jared Leto", "Matt Smith", "Adria Arjona", "Jared Harris" },
    Genre = "Action, Adventure, Horror, Sci-Fi, Thriller",
    ReleaseDate = new DateTime(2022, 4, 1),
    MovieInfo = "Dr. Morbius unleashes a darkness inside of him when he tries to cure his rare blood disorder",
    ImageUrl = "/image/m30.jpg"
}
        };

        private static List<Movie> watchList = new List<Movie>();
        private static List<Movie> toWatchList = new List<Movie>();

        public ActionResult Index(string searchString, string cast)
        {
            var filteredMovies = new List<Movie>(movies);

            // Filter by search string
            if (!String.IsNullOrEmpty(searchString))
            {
                var searchedMovie = movies.FirstOrDefault(m => m.Title.Contains(searchString, StringComparison.OrdinalIgnoreCase) || m.Genre.Contains(searchString, StringComparison.OrdinalIgnoreCase) || m.Cast.Any(actor => actor.Equals(searchString, StringComparison.OrdinalIgnoreCase)));

                if (searchedMovie != null)
                {
                    // Remove the searched movie from its current position
                    filteredMovies.Remove(searchedMovie);

                    // Find the index of the first movie with the searched cast
                    int index = filteredMovies.FindIndex(m => m.Cast.Contains(cast, StringComparer.OrdinalIgnoreCase));
                    if (index != -1)
                    {
                        // Insert the searched movie before the first movie with the searched cast
                        filteredMovies.Insert(index, searchedMovie);
                    }
                    else
                    {
                        // If the cast is not found, insert the searched movie at the beginning
                        filteredMovies.Insert(0, searchedMovie);
                    }
                }
            }

            // Filter by cast
            if (!String.IsNullOrEmpty(cast))
            {
                var moviesWithCast = movies.Where(m => m.Cast.Any(actor => actor.Equals(cast, StringComparison.OrdinalIgnoreCase))).ToList();

                if (moviesWithCast.Any())
                {
                    // Remove all movies with the searched cast from their current positions
                    foreach (var movie in moviesWithCast)
                    {
                        filteredMovies.Remove(movie);
                    }

                    // Insert all movies with the searched cast at the beginning
                    filteredMovies.InsertRange(0, moviesWithCast);
                }
            }

            // Sort by genre if searchString is provided but no cast filter
            if (!String.IsNullOrEmpty(searchString) && String.IsNullOrEmpty(cast))
            {
                filteredMovies.Sort((x, y) =>
                {
                    if (x.Genre.Contains(searchString, StringComparison.OrdinalIgnoreCase) && !y.Genre.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    {
                        return -1;
                    }
                    else if (!x.Genre.Contains(searchString, StringComparison.OrdinalIgnoreCase) && y.Genre.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                });
            }

            return View(filteredMovies);
        }
        public ActionResult Details(int id)
        {
            var movie = movies.Find(m => m.Id == id);
            return View(movie);
        }

        public ActionResult WatchList()
        {
            var viewModel = new WatchListView
            {
                WatchList = watchList
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Watched(int id)
        {
            var movie = movies.FirstOrDefault(m => m.Id == id);

            if (movie != null)
            {
             
                if (!watchList.Contains(movie))
                {
                    watchList.Add(movie);
                }
            }

          
            return RedirectToAction("Index");
        }

        public ActionResult ToWatchList()
        {
            var viewModel = new WatchListView
            {
                WatchList = toWatchList
            };

            return View(viewModel);
        }

        public ActionResult ToWatch(int id)
        {
            var movie = movies.FirstOrDefault(m => m.Id == id);

            if (movie != null)
            {
             
                if (!toWatchList.Contains(movie))
                {
                    toWatchList.Add(movie);
                }
            }

       
            return RedirectToAction("Index");
        }
    }
}