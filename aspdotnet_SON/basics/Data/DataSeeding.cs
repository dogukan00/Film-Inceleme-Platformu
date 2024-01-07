using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using basics.Entity;

namespace basics.Data
{
    public static class DataSeeding
    {
        
        public static void Seed(IApplicationBuilder app)
        {

            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MovieContext>();
            context!.Database.Migrate();

           if(context.Database.GetPendingMigrations().Count()==0)
            {
                if(context.Movies.Count()==0)
                {
                    context.Movies.AddRange(
                        new List<Movie>()
        {
                new Movie()
                {
                    Id=1,
                    Name="Iron Man",
                    Description="<p>Tony Stark presents his new weapon to American Generals in Afghanistan. On the way back, they are attacked by a team of terrorists. Tony and the soldiers with him are shot with Stark weapons. Soldiers die. Tony is taken prisoner. Terrorists ask him to make a new weapon for them. A man named Yinsen, who was imprisoned with him, prevented the pieces of shrapnel that hit Tony's body from going to his heart with the help of the battery and saved his life. They build the first small arc-reactor and place it in Tony's chest. This keeps the shrapnel fragments from going into the heart. Then they pretend to be making weapons together and secretly make an armor. Once the armor is complete, the terrorists understand the situation and attack. Meanwhile, Yinsen stalls the terrorists and dies, sacrificing his own life to buy Tony time. Tony kills the terrorists and escapes from there. American soldiers find him and he returns home. The events he experienced changed him. He declares that he will no longer manufacture weapons. His partner, Obadiah Stane, wouldn't be happy about it. Tony begins work on a new armor. Once the armor is complete, he goes to Afghanistan and attacks the terrorists there. Destroys their weapons. Meanwhile, it turns out that Obadiah Stane hired the terrorists to kill Tony. Obadiah paralyzes Tony at his home and dismantles the arc-reactor, leaving him to die. Obadiah has made himself an armor similar to Tony's at the Company. When Tony is dying, J.A.R.V.I.S brings the spare arc-reactor and Tony puts it on his chest. Obadiah armor and Iron Man armor clash. Obadiah dies. Tony tells the press it's him.</p>",
                    ShortDescription="Tony Stark, a famous inventor and billionaire, takes over his father's company called Stark Izndustries and starts producing weapons. He makes money from guns and gets into people's blood. This makes Tony Stark feel responsible to people.",
                    ImageUrl="1.jpg",
                    CategoryId = 1
                },
                new Movie() {
                    Id=2,
                    Name="Incir Receli",
                    Description="<p>Metin, who is in his 30s, continues his life by writing sketches for television shows. While his biggest dream is to shoot a movie he wrote, the screenplays he wrote are always rejected. One day, he meets a girl named Duygu at the bar he goes to every day. He takes Duygu, who is too drunk to stand, to his house, gives her his bed while she is lying on the sofa, and when he wakes up in the morning, he sees that Duygu has left with a small note. They meet again later, Duygu stays at Metin's house again, but always the same way, Duygu leaves the house early in the morning leaving a small note. Metin wonders why this girl, whom he is in love with but knows only her name, behaves this way. An immortal metropolitan love is born when Duygu explains to Metin that she is living with HIV during their encounter in the subway.</p>",
                    ShortDescription="Metin is a man in his 30s who earns his living by writing skits on TV. One day, when her scripts were rejected, she meets Duygu, who changes her life completely at the bar she goes to. Duygu and Metin start with a fairy tale, but it is a fairy tale with a definite end from the beginning.",
                    ImageUrl="2.jpg",
                    CategoryId = 2
                },
                new Movie() {
                    Id=3,
                    Name="Ask ve Gurur",
                    Description="<p>In the early 19th century, the Bennet family live at their Longbourn estate, situated near the village of Meryton in Hertfordshire, England. Mrs Bennet's greatest desire is to marry off her five daughters to secure their futures. The arrival of Mr Bingley, a rich bachelor who rents the neighbouring Netherfield estate, gives her hope that one of her daughters might contract an advantageous marriage, because It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.At a ball, the family is introduced to the Netherfield party, including Mr Bingley, his two sisters and Mr Darcy, his dearest friend. Mr Bingley's friendly and cheerful manner earns him popularity among the guests. He appears interested in Jane, the eldest Bennet daughter. Mr Darcy, reputed to be twice as wealthy as Mr Bingley, is haughty and aloof, causing a decided dislike of him. He declines to dance with Elizabeth, the second-eldest Bennet daughter, as she is not handsome enough.Although she jokes about it with her friend, Elizabeth is deeply offended. Despite this first impression, Mr Darcy secretly begins to find himself drawn to Elizabeth as they continue to encounter each other at social events, appreciating her wit and frankness.</p>",
                    ShortDescription="It is about the contentious love between a wealthy man named Fitzwilliam Darcy and Elizabeth Bennett, the daughter of a middle-class family. The biggest common aspects of these two characters, who are completely opposite to each other, are their proud and prejudiced attitudes towards each other.",
                    ImageUrl="3.jpg",
                    CategoryId = 2
                },
                new Movie() {
                    Id=4,
                    Name="Inception ",
                    Description="<p>Dom Cobb (Leonardo DiCaprio) is a very skilled thief. His specialty is to extract and steal valuable secrets from the depths of the subconscious mind during dreaming, when the mind is most vulnerable. Cobb's rare dexterity has made him a sought-after player in the dangerous new world of corporate espionage. However, it has also made him an international fugitive and has cost him everything he loves. Cobb is presented with an opportunity to get out of his situation. One last job that could give him his life back; if he can complete the impossible beginning. Instead of the perfect heist, Cobb and the pros on his team must do the opposite this time; Their job is not to steal an idea, but to plant it. If they succeed, it will be the perfect crime. But neither careful planning nor expertise can prepare them for dangerous foes who seem to anticipate their every move. This is an enemy whose arrival only Cobb can see.</p>",
                    ShortDescription="Dom Cobb (Leonardo DiCaprio) is a very skilled thief. His specialty is to extract and steal valuable secrets from the depths of the subconscious during dreaming, when the mind is at its most vulnerable. Cobb's rare dexterity has made him a sought-after player in the dangerous new world of corporate espionage.",
                    ImageUrl="4.jpg",
                    CategoryId = 3
                },
                new Movie() {
                    Id=5,
                    Name="Interstellar",
                    Description="<p>In the near future, civilization declined to the level of agricultural society due to a mold that caused the death of grain crops. Joseph Cooper, a widowed engineer and former NASA pilot, runs a farm with his family. He is now a farmer. They have a 15-year-old son (Tom Cooper) and a 10-year-old daughter (Murphy Murph Cooper). After a dust storm, inexplicably strange dust patterns appear on the floor of Murphy's bedroom; attributes the anomaly to a ghost. Cooper eventually thinks that the patterns are due to gravitational variations and that they represent geographic coordinates in binary code. Cooper's daughter, Murphy; She thinks that a ghost is communicating with her in her room. They then discover that the unknown intelligence sent by Murph's ghost is encoded using gravitational waves.</p>",
                    ShortDescription="In Interstellar, Cooper, who is highly technical and skilled, makes a living by farming large cornfields; His aim is to provide a safe life for his two children. Grandpa Donald, who lives with them, takes care of the children, while his 10-year-old daughter, Murph, has a surprising intelligence.",
                    ImageUrl="5.jpg",
                    CategoryId = 3
                }
        }
                    );
                }
                if(context.Categories.Count()==0)
                {
                    context.Categories.AddRange(
                        new List<Category>()
                        {
                            new Category() {Id=1, Name="Macera"},
                            new Category() {Id=2, Name="Romantik"},
                            new Category() {Id=3, Name="Bilim Kurgu"},
                            new Category() {Id=4, Name="Savaş"},
                            new Category() {Id=5, Name="Komedi"}
                        }
                        
                    );
                }

                context.SaveChanges(); 
            }
        }



    }
}