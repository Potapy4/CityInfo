using CityInfo.API.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>
            {
                new City
                {
                    Name = "Lviv",
                    Description = "Lviv is one of the main cultural centres of Ukraine.",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Name = "Private City Tour of Lviv",
                            Description = "The tour will show you the most remarkable sights of the ancient city, which has preserved as an indivisible architectural ensemble in spite of wars, fires and revolutions - the medieval Rynok Square with the Town Hall and a set of ancient buildings, the Gothic Latin Cathedral, beautiful Cathedrals of Bernadines, Jesuits and Dominicans, ruin of the all – Europe famous Golden Rosa Synagogue, magnificent city fortifications, including the Town and Royal Armouries, Gunpowder Tower and other old relics."
                        },
                        new PointOfInterest
                        {
                            Name = "Chocolate and Coffee Traditions of Lviv Private Walking Tour",
                            Description = "Discover a magical world of coffee and chocolate and visit the most noticeable coffee houses in Lviv. The local guide will meet you in the center of the city and lead you through the unique places to learn an incredible story of Lviv coffee and chocolate."
                        },
                        new PointOfInterest
                        {
                            Name = "Armenian street",
                            Description = "Armenian Street is a hub of activity- from shops, art galleries, bars and restaraunts, it's all here. The architecture is wonderful, ranging from the enchanting side garden of the Armenian Cathedral to many, many old structures."
                        }
                    }
                },
                new City
                {
                    Name = "Kiev",
                    Description = "Kiev is the capital and largest city of Ukraine, located in the north central part of the country on the Dnieper River.",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Name = "Kiev-Pechersk Lavra - Caves Monastery",
                            Description = "Beautiful building set in a nice peaceful complex with lots of other things to see and do."
                        },
                        new PointOfInterest
                        {
                            Name = "Saint Sophia Cathedral",
                            Description = "The cathedral was built over nine centuries and is a great example of Byzantine and Ukrainian Baroque architecture. The interior contains mosaics and frescoes dating back to the 11th century."
                        },
                        new PointOfInterest
                        {
                            Name = "Rodina Mat (Motherland)",
                            Description = "Impressive statue on top of a hill. It is on the park dedicated to the second world war where you can see military vehicles and a museum. A nice walk though history."
                        }
                    }
                },
                new City
                {
                    Name = "Kharkiv",
                    Description = "Kharkiv is the second-largest city in Ukraine",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Name = "Gorky Central Park of Culture and Leisure",
                            Description = "Central Park of Culture and Rest in Kharkov - the best theme park in Ukraine, one of the best in Europe. This is confirmed by a number of awards and positive feedback from our visitors, including Tripadvisor users."
                        },
                        new PointOfInterest
                        {
                            Name = "Mirror Stream fountain",
                            Description = "Nice monument changing colour lights good for sightseeing and photos just off the main road but still fairly peaceful."
                        },
                        new PointOfInterest
                        {
                            Name = "Kharkov Dolphinarium",
                            Description = "Here is a good place to visit and it is on everyone's list of things to see when visiting Kharkiv, you don't have to be a SeaWorld lover to appreciate this place."
                        }
                    }
                },
                new City
                {
                    Name = "Dnipro",
                    Description = "Dnipro is Ukraine's fourth largest city, with about one million inhabitants",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Name = "Menorah Centre",
                            Description = "The Menorah is a unique building and the world's largest Jewish complex, equal to none elsewhere on Earth. This project shows the past, present and future of Jewish life in the city of Dnepr. The unique architectural design of the building, convenient location in the heart of the city, high standards of service along with modern technical equipment are the basis for a successful business, comfortable stay and a hearty reception."
                        },
                        new PointOfInterest
                        {
                            Name = "Taras Shevchenko Park",
                            Description = "Good place for relax. calm iland in the big city. a lot of places to walking, to sightseeng, and swimming."
                        },
                        new PointOfInterest
                        {
                            Name = "Karl Marx Prospect",
                            Description = "Nice walk with a lot of threes supplying you the shadow in a hot summer day. Nice monument and view of Dnipro river at the end."
                        }
                    }
                },
                new City
                {
                    Name = "Odesa",
                    Description = "Odesa is the third most populous city of Ukraine and a major tourism center, seaport and transportation hub located on the northwestern shore of the Black Sea.",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Name = "Odessa National Opera and Ballet Theater",
                            Description = "Ukrainians are more than familiar with Russian musicians such as Tchaikovsky and Stravinsky so Ukraine is the perfect place to get acquainted with their masterpieces for an extremely affordable price. In Odessa this can be done at one of the city’s most famous buildings, the National Opera and Ballet Theater."
                        },
                        new PointOfInterest
                        {
                            Name = "Lanzheron beach",
                            Description = "Odessa is a coastal city so naturally locals enjoy dipping their toes in the Black Sea. There are many beaches all over the city, even in the center, and all of them are very popular in the summer. Most beaches have free, paid, and VIP zones. The closest to the center is Lanzheron, but just others such as Otrada and Dolphin are just a short cab ride away."
                        },
                        new PointOfInterest
                        {
                            Name = "The Odessa Catacombs",
                            Description = "Underneath Odessa lies a huge network of tunnels known as the Odessa catacombs. They are a big part of the city’s history, having been a refuge for Soviet partisans during World War II and later smugglers. Nowadays, there is a small museum on the partisan movement, the Museum of Partisan Glory, and you can explore the tunnels on organized tours such as the Secrets of Underground Odessa. Do not attempt to visit these tunnels on your own or with an unregistered guide."
                        }
                    }
                },
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
