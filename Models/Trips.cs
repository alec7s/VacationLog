using static VacationLog.Models.Vacation;

namespace VacationLog.Models
{
    public static class Trips
    {
        public static List<Vacation> History()
        {
            return new List<Vacation>()
            {
                //LOG PAGE CONTENT
                //EACH STRING ITEM IN DESCRIPTION LIST IS A PARAGRAPH TO APPEAR ON THE LOG PAGE FOR THE VACATION
                new Vacation(
                    id: 1,
                    author: "alec7s",
                    page: "Chincoteague", title: "Chincoteague", year: 2018, month: "August", 
                    images: new List<Image>
                    {
                        new Image(
                            id: 1,
                            caption: "1st Landing St.Park - campground beach access, 2018",
                            altText: "Walkway to beach with water in distance"
                            ), 
                        new Image(
                            id: 2,
                            caption: "Our campsite",
                            altText: "Campsite on beach at First Landing State Park"
                        ), 
                        new Image(
                            id: 3,
                            caption: "Ponies from a distance, Assateague",
                            altText: "Marsh landscape with ponies in the distance at Assateague Nature Preserve"
                        )
                    },
                    description: new List<string>
                    {
                        @"At the end of August in 2018, we drove south to the Virginia Beach area and camped for a night on the beach at First Landing State Park. It was a sandy and secluded campsite with easy beach access.",
                        @"The next day we drove back into Maryland to Chincoteague Island, where we explored the charming town and the nature preserve on Assateague Island. It was great to see the wild ponies, even from afar. We had to cover ourselves from head-to-toe at Assateague becuase it was raining for most of our time there, and the mosquitoes were intense.",
                        @"Back in town, we enjoyed some tasty seafood at Steamers and Mr. Whippy's ice cream -- a long time favorite.",
                        @"Chincoteague is only a few hours away from where we live, so we'll certainly be back to visit again." 
                    }
                ),

                new Vacation(
                    id: 2,
                    author: "alec7s",
                    page: "California", title: "California", year: 2019, month: "February",
                    images: new List<Image>
                    {
                        new Image(
                            id: 1,
                            caption: "Dessert oasis, Joshua Tree National Park",
                            altText: "Mountainous and rocky dessert area with palm trees at Joshua Tree National Park"
                            ),
                        new Image(
                            id: 2,
                            caption: "Tree tops at Sequoia",
                            altText: "Looking up from the bottom of a grove of Sequoia trees in the snow at Sequoia National Park"
                        ),
                        new Image(
                            id: 3,
                            caption: "Badlands at Death Valley",
                            altText: "Mountainous dessert landscape view of badlands at Death Valley National Park"
                        )
                    },
                    description: new List<string>
                    {
                        @"In February 2019, we purchased a one way ticket to Los Angeles... and a one way return flight from Las Vegas. Once we arrived in LA, we hopped in our rental and headed to the desert.",
                        @"First stop, Joshua Tree National Park where we were expecting warm weather in the 60s and 70s, but we found ourselves in the middle of some unusually cold winter weather. One day it even snowed! We mostly stayed at some local rentals and camped two nights in temperatures below freezing.",
                        @"We loved exploring and climbing in the large boulder patches scattered throughout the park. They were so many spots that we could access easily, and they seemed to just go on and on. There always seemed to be one patch after another.",
                        @"Next, we set off for the Sierra Nevadas to explore Sequoia National Park. We stayed about 40 minutes away from the park on an orange farm, where the farm dogs ran wild and the fruit was ripe for picking.",
                        @"On the day we arrived, there was a large snowstorm that hit the area of the park where the Sequoia trees could be found. We ended up renting snow chains for our tires and eventually made it up to the higher elevation to find a six-foot layer of snow surrounding the magnificent trees. Much of the park was closed due to the snow, but we still saw a lot of it on foot while snowshoeing.",
                        @"The last park on our trip was Death Valley. The park was incredibly vast, and it was difficult to decide where to start the sightseeing. We started off by visiting the salt flats, which also happen to be the lowest point in the continental US. We hiked several canyons, saw the dunes, and enjoyed the warm weather at about 85 degrees fahrenheit each day.",
                        @"On our final night, we stayed in Las Vegas, wandering around the strip and taking in the fun vibes." 
                    }
                ),

                new Vacation(
                    id: 3,
                    author: "alec7s",
                    page: "Asheville", title: "Asheville and Knoxville", year: 2019, month: "November",
                    images: new List<Image>
                    {
                        new Image(
                            id: 1,
                            caption: "Bouldering spot",
                            altText: "Close-up of crevice between boulders"
                        ),
                        new Image(
                            id: 2,
                            caption: "Hike near Knoxville, TN",
                            altText: "Valley with small mountains, river, and barren trees"
                        ),
                        new Image(
                            id: 3,
                            caption: "View from Looking Glass Rock",
                            altText: "Vista from Looking Glass Rock with evergreen tree in Pisgah National Forest"
                        )
                    },
                    description: new List<string>
                    {
                        @"In November of 2019, we headed down the 81 corridor to Knoxville, where we stayed with friends for a couple nights and explored the city.",
                        @"Next, we headed east to Asheville near the Smoky Mountains. We rented a cozy, little cabin with a bright and warm fireplace. We hiked in Pisgah National Forest by day and enjoyed the food scene in Asheville by night.",
                        @"Our final stop was in Roanoke on the way home, where we hiked and reflected on the fun memories from our trip south." 
                    }
                ),
                new Vacation(
                    id: 4,
                    author: "alec7s",
                    page: "NewEngland",title: "New England", year: 2021, month: "August",
                    images: new List<Image>
                    {
                        new Image(
                            id: 1,
                            caption: "Peaks Island, ME",
                            altText: "Rocky beach cove with small boats in Maine"
                        ),
                        new Image(
                            id: 2,
                            caption: "Franconia Ridge, NH, 2021",
                            altText: "Rocky trail sloping downhill and foggy mountain vista in New Hampshire"
                        ),
                        new Image(
                            id: 3,
                            caption: "Battery Steele",
                            altText: "Wall covered in colorful graffiti and a dark doorway"
                        )
                    },
                    description: new List<string>
                    {
                        @"It all started with a long drive north to Maine, where we started with some fun beach time with friends.",
                        @"Next, we set our sights to the city of Portland where we did plenty of walking and a lot of eating. We also took the ferry to Peaks Island to bike and explore the abandoned fort, which was covered in artistic graffiti.",
                        @"After a few days, we headed to New Hampshire where we camped and completed one of the toughest hikes that we had ever experienced. It was incredibly challenging and beautiful despite the fog, which crushed our anticipation of 360 degree views along the ridgeline." ,
                        @"Following the hike, we headed straight to Vermont to stay with some family, relax, and enjoy the fresh air.",
                        @"Finally, we stopped in Connecticut before driving home, where we enjoyed a night out with friends." 
                    }
                )
            };
        }
    }
}
