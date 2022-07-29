var list = new GenericList<Hero>();
var hero1 = new Hero("Echo");
hero1.Image = "lkdsajflkajflksajdflkjdsalkfjsdlf";
hero1.Name = "Echo";
hero1.Description = "Echo is the annoying iPhone that flies around.";
hero1.Role = "DPS";

var hero2 = new Hero("Mercy");
hero2.Image = "lkdsajflkajflksajdflkjdsalkfjsdlf";
hero2.Name = "Mercy";
hero2.Description = "Mercy is the best healer in the game who also flies around";
hero2.Role = "Support";
hero2.Secondary = "Healer";

var hero3 = new Hero("Echo");
hero3.Image = "lkdsajflkajflksajdflkjdsalkfjsdlf";
hero3.Name = "Echo";
hero3.Description = "Echo is the annoying iPhone that flies around.";
hero3.Role = "DPS";

list.Add(hero1);
list.Add(hero2);
list.Remove(hero3);

Console.WriteLine(list.ToString());
Console.WriteLine(list.Size());

