using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace PokemonList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon Bulbasaur = new Pokemon()
            {
                Name = "妙蛙種子",
                Sex = "♂",
                HP = "60 / 60",
                Weight = "5.94",
                Type = "草 / 毒",
                Height = "0.67",
                PlayerStardust = "271484",
                PlayerCandy = "27",
                PowerUp = "3000 星星沙子   3 顆妙蛙種子的糖果",
                Evolve = "25 顆妙蛙種子的糖果",
                Skills = "藤鞭、汙泥炸彈",
                LocationCaught = "台灣 新北 三重區",
                DateCaught = "09/14/2016",
            };
            Console.WriteLine("Pokemon－{0} {1}\nHP {2}\n體重：{3}Kg  類型：{4}　身高：{5}Cm\n\n" +
                "目前擁有的星星沙子：{6}  目前擁有的妙蛙種子糖果：{7}\n\n" +
                "強化所需的材料：{8}\n所需的材料：{9}\n技能：{10}\n\n" +
                "捕捉地點：{11}\n捕捉時間：{12}\n\n"
                , Bulbasaur.Name
                , Bulbasaur.Sex
                , Bulbasaur.HP
                , Bulbasaur.Weight
                , Bulbasaur.Type
                , Bulbasaur.Height
                , Bulbasaur.PlayerStardust
                , Bulbasaur.PlayerCandy
                , Bulbasaur.PowerUp
                , Bulbasaur.Evolve
                , Bulbasaur.Skills
                , Bulbasaur.LocationCaught
                , Bulbasaur.DateCaught
                );
        }
    }
}