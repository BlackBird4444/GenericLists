var list = new MattsList<Hero>();
var hero1 = new Hero();
hero1.Id = "Echo";
hero1.Image = "lkdsajflkajflksajdflkjdsalkfjsdlf";
hero1.Name = "Echo";
hero1.Description = "Echo is the annoying iPhone that flies around.";
hero1.Role = "DPS";

var hero2 = new Hero();
hero2.Id = "Mercy";
hero2.Image = "lkdsajflkajflksajdflkjdsalkfjsdlf";
hero2.Name = "Mercy";
hero2.Description = "Mercy is the best healer in the game who also flies around";
hero2.Role = "Support";
hero2.Secondary = "Healer";

list.Add(hero1);
list.Add(hero2);

Console.WriteLine(list.ToString());
Console.WriteLine(list.Size());