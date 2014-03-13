namespace GreggsListData.Migrations
{
    using GreggsListData.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GreggsListData.GreggsListContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GreggsListData.GreggsListContext context)
        {
            context.Users.AddOrUpdate(
                    u => u.Id,
                    new User { UserName = "DirtyDan", Address = "Somewhere, Seattle Washington" },
                    new User { UserName = "SuzyStorm", Address = "Cloud City, Texas" },
                    new User { UserName = "SCBDrewfus", Address = "Dark-Side, The Moon" },
                    new User { UserName = "IceMan", Address = "North Pole" }
                    );

            context.States.AddOrUpdate(
                s => s.Name,
                new State { Name = "Alabama" },
                new State { Name = "Alaska" },
                new State { Name = "Arizona" },
                new State { Name = "Arkansas" },
                new State { Name = "California" },
                new State { Name = "Colorado" },
                new State { Name = "Connecticut" },
                new State { Name = "Delaware" },
                new State { Name = "Florida" },
                new State { Name = "Georgia" },
                new State { Name = "Hawaii" },
                new State { Name = "Idaho" },
                new State { Name = "Illinois" },
                new State { Name = "Indiana" },
                new State { Name = "Iowa" },
                new State { Name = "Kansas" },
                new State { Name = "Kentucky" },
                new State { Name = "Louisiana" },
                new State { Name = "Maine" },
                new State { Name = "Maryland" },
                new State { Name = "Massachusetts" },
                new State { Name = "Michigan" },
                new State { Name = "Minnesota" },
                new State { Name = "Mississippi" },
                new State { Name = "Missouri" },
                new State { Name = "Montana" },
                new State { Name = "Nebraska" },
                new State { Name = "Nevada" },
                new State { Name = "New Hampshire" },
                new State { Name = "New Jersey" },
                new State { Name = "New Mexico" },
                new State { Name = "New York" },
                new State { Name = "North Carolina" },
                new State { Name = "North Dakota" },
                new State { Name = "Ohio" },
                new State { Name = "Oklahoma" },
                new State { Name = "Oregon" },
                new State { Name = "Pennsylvania" },
                new State { Name = "Rhode Island" },
                new State { Name = "South Carolina" },
                new State { Name = "South Dakota" },
                new State { Name = "Tennessee" },
                new State { Name = "Texas" },
                new State { Name = "Utah" },
                new State { Name = "Vermont" },
                new State { Name = "Virginia" },
                new State { Name = "Washington" },
                new State { Name = "West Virginia" },
                new State { Name = "Wisconsin" },
                new State { Name = "Wyoming" }

            );
            context.Regions.AddOrUpdate(
                r => r.Name,
                new Region { Name = "Birmingham", StateId = 1 },
                new Region { Name = "Mobile", StateId = 1 },
                new Region { Name = "Huntsville", StateId = 1 },
                new Region { Name = "Montgomery", StateId = 1},
                new Region { Name = "Tuscaloosa", StateId = 1},
                new Region { Name = "Anchorage", StateId = 2 },
                new Region { Name = "Juneau", StateId = 2 },
                new Region { Name = "Fairbanks", StateId = 2 },
                new Region { Name = "Sitka", StateId = 2 },
                new Region { Name = "Nome", StateId = 2},
                new Region { Name = "Phoenix", StateId = 3 },
                new Region { Name = "Tuscon", StateId = 3 },
                new Region { Name = "Scottsdale", StateId = 3 },
                new Region { Name = "Sedona", StateId = 3},
                new Region { Name = "Tempe", StateId = 3},
                new Region { Name = "Little Rock", StateId = 4 },
                new Region { Name = "Fayetteville", StateId = 4 },
                new Region { Name = "Hot Springs", StateId = 4 },
                new Region { Name = "Fort Smith", StateId = 4 },
                new Region { Name = "Texarkana", StateId = 4 },
                new Region { Name = "Los Angeles", StateId = 5 },
                new Region { Name = "San Francisco", StateId = 5 },
                new Region { Name = "San Diego", StateId = 5 },
                new Region { Name = "Sacramento", StateId = 5 },
                new Region { Name = "Long Beach", StateId = 5 },
                new Region { Name = "Denver", StateId = 6 },
                new Region { Name = "Colorado Springs", StateId = 6 },
                new Region { Name = "Boulder", StateId = 6 },
                new Region { Name = "Fort Collins", StateId = 6 },
                new Region { Name = "Englewood", StateId = 6 },
                new Region { Name = "Hartford", StateId = 7 },
                new Region { Name = "New Haven", StateId = 7 },
                new Region { Name = "Stamford", StateId = 7 },
                new Region { Name = "Bridgeport", StateId = 7 },
                new Region { Name = "Norwalk", StateId = 7 },
                new Region { Name = "Wilmington", StateId = 8 },
                new Region { Name = "Dover", StateId = 8 },
                new Region { Name = "Rehoboth Beach", StateId = 8 },
                new Region { Name = "Newark", StateId = 8 },
                new Region { Name = "Lewes", StateId = 8 },
                new Region { Name = "Miami", StateId = 9 },
                new Region { Name = "Tampa bay", StateId = 9 },
                new Region { Name = "Orlando", StateId = 9 },
                new Region { Name = "Jacksonville", StateId = 9 },
                new Region { Name = "Fort Lauderdale", StateId = 9 },
                new Region { Name = "Atlanta", StateId = 10 },
                new Region { Name = "Savannah", StateId = 10 },
                new Region { Name = "Marietta", StateId = 10 },
                new Region { Name = "Augusta", StateId = 10 },
                new Region { Name = "Athens", StateId = 10 },
                new Region { Name = "Honolulu", StateId = 11 },
                new Region { Name = "Hilo", StateId = 11 },
                new Region { Name = "Kailua", StateId = 11 },
                new Region { Name = "Kaneohe", StateId = 11 },
                new Region { Name = "Haleiwa", StateId = 11 },
                new Region { Name = "Boise", StateId = 12 },
                new Region { Name = "Nampa", StateId = 12 },
                new Region { Name = "Coeur d'Alene", StateId = 12 },
                new Region { Name = "Pocatello", StateId = 12 },
                new Region { Name = "Idaho Falls", StateId = 12 },
                new Region { Name = "Chicago", StateId = 13 },
                new Region { Name = "Springfield", StateId = 13 },
                new Region { Name = "Peoria", StateId = 13 },
                new Region { Name = "Naperville", StateId = 13 },
                new Region { Name = "Champaign", StateId = 13 },
                new Region { Name = "Indianapolis", StateId = 14 },
                new Region { Name = "Fort Wayne", StateId = 14 },
                new Region { Name = "South Bend", StateId = 14 },
                new Region { Name = "Bloomington", StateId = 14 },
                new Region { Name = "Evansville", StateId = 14 },
                new Region { Name = "Des Moines", StateId = 15 },
                new Region { Name = "Cedar Rapids", StateId = 15 },
                new Region { Name = "Iowa City", StateId = 15 },
                new Region { Name = "Ames", StateId = 15 },
                new Region { Name = "Dubuque", StateId = 15 },
                new Region { Name = "Wichita", StateId = 16 },
                new Region { Name = "Topeka", StateId = 16 },
                new Region { Name = "Overland Park", StateId = 16 },
                new Region { Name = "Kansas City", StateId = 16 },
                new Region { Name = "Olathe", StateId = 16 },
                new Region { Name = "Louisville", StateId = 17 },
                new Region { Name = "Lexington", StateId = 17 },
                new Region { Name = "Frankfort", StateId = 17 },
                new Region { Name = "Paducah", StateId = 17 },
                new Region { Name = "Bowling Green", StateId = 17 },
                new Region { Name = "New Orleans", StateId = 18 },
                new Region { Name = "Baton Rouge", StateId = 18 },
                new Region { Name = "Shreveport", StateId = 18 },
                new Region { Name = "Lake Charles", StateId = 18 },
                new Region { Name = "Lafayette", StateId = 18 },
                new Region { Name = "Portland", StateId = 19 },
                new Region { Name = "Bangor", StateId = 19 },
                new Region { Name = "Augusta", StateId = 19 },
                new Region { Name = "Bar Harbor", StateId = 19 },
                new Region { Name = "Kennebunkport", StateId = 19 },
                new Region { Name = "Baltimore", StateId = 20 },
                new Region { Name = "Annapolis", StateId = 20 },
                new Region { Name = "Ocean City", StateId = 20 },
                new Region { Name = "Frederick", StateId = 20 },
                new Region { Name = "Rockville", StateId = 20 },
                new Region { Name = "Boston", StateId = 21 },
                new Region { Name = "Cambridge", StateId = 21 },
                new Region { Name = "Salem", StateId = 21 },
                new Region { Name = "Worchester", StateId = 21 },
                new Region { Name = "Cape Cod", StateId = 21 },
                new Region { Name = "Detroit", StateId = 22 },
                new Region { Name = "Grand Rapids", StateId = 22 },
                new Region { Name = "Ann Arbor", StateId = 22 },
                new Region { Name = "Lansing", StateId = 22 },
                new Region { Name = "Kalamazoo", StateId = 22 },
                new Region { Name = "Minneapolis", StateId = 23 },
                new Region { Name = "Saint Paul", StateId = 23 },
                new Region { Name = "Duluth", StateId = 23 },
                new Region { Name = "Minnetonka", StateId = 23 },
                new Region { Name = "Rochester", StateId = 23 },
                new Region { Name = "Jackson", StateId = 24 },
                new Region { Name = "Biloxi", StateId = 24 },
                new Region { Name = "Gulfport", StateId = 24 },
                new Region { Name = "Hattiesburg", StateId = 24 },
                new Region { Name = "Natchez", StateId = 24 },
                new Region { Name = "St. Louis", StateId = 25 },
                new Region { Name = "Kansas City", StateId = 25 },
                new Region { Name = "Springfield", StateId = 25 },
                new Region { Name = "Branson", StateId = 25 },
                new Region { Name = "Columbia", StateId = 25 },
                new Region { Name = "Missoula", StateId = 26 },
                new Region { Name = "Bozeman", StateId = 26 },
                new Region { Name = "Billings", StateId = 26 },
                new Region { Name = "Helena", StateId = 26 },
                new Region { Name = "Great Falls", StateId = 26 },
                new Region { Name = "Omaha", StateId = 27 },
                new Region { Name = "Lincoln", StateId = 27 },
                new Region { Name = "Grand Island", StateId = 27 },
                new Region { Name = "Papillion", StateId = 27 },
                new Region { Name = "Kearney", StateId = 27 },
                new Region { Name = "Las Vegas", StateId = 28 },
                new Region { Name = "Reno", StateId = 28 },
                new Region { Name = "Carson City", StateId = 28 },
                new Region { Name = "Henderson", StateId = 28 },
                new Region { Name = "Elko", StateId = 28 },
                new Region { Name = "Nashua", StateId = 29 },
                new Region { Name = "Manchester", StateId = 29 },
                new Region { Name = "Portsmouth", StateId = 29 },
                new Region { Name = "Concord", StateId = 29 },
                new Region { Name = "Dover", StateId = 29 },
                new Region { Name = "Newark", StateId = 30 },
                new Region { Name = "Atlantic City", StateId = 30 },
                new Region { Name = "Jersey City", StateId = 30 },
                new Region { Name = "Teaneck", StateId = 30 },
                new Region { Name = "Trenton", StateId = 30 },
                new Region { Name = "Albuquerque", StateId = 31 },
                new Region { Name = "Sante Fe", StateId = 31 },
                new Region { Name = "Las Cruces", StateId = 31 },
                new Region { Name = "Roswell", StateId = 31 },
                new Region { Name = "Taos", StateId = 31 },
                new Region { Name = "New York City", StateId = 32 },
                new Region { Name = "Buffalo", StateId = 32 },
                new Region { Name = "Albany", StateId = 32 },
                new Region { Name = "Rochester", StateId = 32 },
                new Region { Name = "Syracuse", StateId = 32 },
                new Region { Name = "Raleigh", StateId = 33 },
                new Region { Name = "Charlotte", StateId = 33 },
                new Region { Name = "Asheville", StateId = 33 },
                new Region { Name = "Greensboro", StateId = 33 },
                new Region { Name = "Wilmington", StateId = 33 },
                new Region { Name = "Fargo", StateId = 34 },
                new Region { Name = "Bismarck", StateId = 34 },
                new Region { Name = "Minot", StateId = 34 },
                new Region { Name = "Grand Forks", StateId = 34 },
                new Region { Name = "Williston", StateId = 34 },
                new Region { Name = "Columbus", StateId = 35 },
                new Region { Name = "Cincinnati", StateId = 35 },
                new Region { Name = "Cleveland", StateId = 35 },
                new Region { Name = "Akron", StateId = 35 },
                new Region { Name = "Toledo", StateId = 35 },
                new Region { Name = "Oklahoma City", StateId = 36 },
                new Region { Name = "Tulsa", StateId = 36 },
                new Region { Name = "Norman", StateId = 36 },
                new Region { Name = "Edmond", StateId = 36 },
                new Region { Name = "Broken Arrow", StateId = 36 },
                new Region { Name = "Portland", StateId = 37 },
                new Region { Name = "Eugene", StateId = 37 },
                new Region { Name = "Bend", StateId = 37 },
                new Region { Name = "Salem", StateId = 37 },
                new Region { Name = "Corvallis", StateId = 37 },
                new Region { Name = "Philadelphia", StateId = 38 },
                new Region { Name = "Pittsburgh", StateId = 38 },
                new Region { Name = "Harrisburg", StateId = 38 },
                new Region { Name = "Lancaster", StateId = 38 },
                new Region { Name = "Allentown", StateId = 38 },
                new Region { Name = "Providence", StateId = 39 },
                new Region { Name = "Newport", StateId = 39 },
                new Region { Name = "Warwick", StateId = 39 },
                new Region { Name = "Pawtucket", StateId = 39 },
                new Region { Name = "Cranston", StateId = 39 },
                new Region { Name = "Columbia", StateId = 40 },
                new Region { Name = "Charleston", StateId = 40 },
                new Region { Name = "Greenville", StateId = 40 },
                new Region { Name = "Myrtle Beach", StateId = 40 },
                new Region { Name = "Spartanburg", StateId = 40 },
                new Region { Name = "Sioux Falls", StateId = 41 },
                new Region { Name = "Rapid City", StateId = 41 },
                new Region { Name = "Deadwood", StateId = 41 },
                new Region { Name = "Sturgis", StateId = 41 },
                new Region { Name = "Brookings", StateId = 41 },
                new Region { Name = "Nashville", StateId = 42 },
                new Region { Name = "Memphis", StateId = 42 },
                new Region { Name = "Knoxville", StateId = 42 },
                new Region { Name = "Chattanooga", StateId = 42 },
                new Region { Name = "Gatlinburg", StateId = 42 },
                new Region { Name = "Houston", StateId = 43 },
                new Region { Name = "Austin", StateId = 43 },
                new Region { Name = "Dallas", StateId = 43 },
                new Region { Name = "San Antonio", StateId = 43},
                new Region { Name = "El Paso", StateId = 43},
                new Region { Name = "Salt Lake City", StateId = 44 },
                new Region { Name = "Provo", StateId = 44 },
                new Region { Name = "Park City", StateId = 44 },
                new Region { Name = "Ogden", StateId = 44 },
                new Region { Name = "St. George", StateId = 44 },
                new Region { Name = "Burlington", StateId = 45 },
                new Region { Name = "Montpelier", StateId = 45 },
                new Region { Name = "Stowe", StateId = 45 },
                new Region { Name = "Killington", StateId = 45 },
                new Region { Name = "Brattleboro", StateId = 45 },
                new Region { Name = "Virgina Beach", StateId = 46 },
                new Region { Name = "Richmond", StateId = 46 },
                new Region { Name = "Charlottesville", StateId = 46 },
                new Region { Name = "Norfolk", StateId = 46 },
                new Region { Name = "Alexandria", StateId = 46 },
                new Region { Name = "Seattle", StateId = 47 },
                new Region { Name = "Spokane", StateId = 47 },
                new Region { Name = "Tacoma", StateId = 47 },
                new Region { Name = "Bellevue", StateId = 47 },
                new Region { Name = "Olympia", StateId = 47 },
                new Region { Name = "Charleston", StateId = 48 },
                new Region { Name = "Morgantown", StateId = 48 },
                new Region { Name = "Huntington", StateId = 48 },
                new Region { Name = "Martinsburg", StateId = 48 },
                new Region { Name = "Wheeling", StateId = 48 },
                new Region { Name = "Milwaukee", StateId = 49 },
                new Region { Name = "Madison", StateId = 49 },
                new Region { Name = "Green Bay", StateId = 49 },
                new Region { Name = "Wisconsin Dells", StateId = 49 },
                new Region { Name = "Oshkosh", StateId = 49 },
                new Region { Name = "Cheyenne", StateId = 50 },
                new Region { Name = "Casper", StateId = 50 },
                new Region { Name = "Laramie", StateId = 50 },
                new Region { Name = "Jackson", StateId = 50 },
                new Region { Name = "Gillette", StateId = 50 }
            );


            context.Items.AddOrUpdate(
                i => i.Id,
                new Item { Name = "Jar of dirt", DateListed = DateTime.Now, RegionId = 1, UserId = 1, Description = "Jar of dirt that briefly held the heart of Davy Jones... Before the heart was stolen by third party pirates... The jar was then accidently dropped by moderately to mostly drunk pirate, and shattered into a million pieces.  So I guess this isn't a real thing. Cheers :)", Price = 5 }
            );

        }
    }
}
