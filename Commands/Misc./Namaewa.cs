using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Karl_Narx_V2.Modules
{
    public class Namaewa : ModuleBase<SocketCommandContext>
    {
        Random rng;
        [Command("Namae wa?")]
        public async Task Nwajugem()
        {
            rng = new Random();
            string[] chance = new string[]
            {"**Watashi wa:**\n *\"Jugemu Jugemu Unko Nageki Ototoi no Shin-chan no Pantsu Shinpachi no Jinsei Balmunk Fezarion Isaac Schneider San Bun no Ichi no Junjou na Kanjou no Nokotta San Bun no Ni wa Sakamuke ga Kininaru Kanjou Uragiri wa Boku no Namae wo Shitteiru you de Shiranai no wo Boku wa Shitteiru Rusu Surume Medaka Kazunoko Koedame Medaka... Kono Medaka wa Sakki to Chigau Yatsu Dakara﻿ Ikeno Medaka no Hou Dakara Raa-yuu Yuuteimiyaouki Mukou Pepepepepepepepepepepepe Bichiguso Maru*\"\nhttps://www.youtube.com/watch?v=XVeneHlix8s",
            "**Watashi wa:**\n *\"Jugemu Go-Kō-no-Surikire Kaijari-suigyo no Suigyō-matsu Unrai-matsu Fūrai-matsu Kū-Neru Tokoro ni Sumu Tokoro Yaburakōji no Burakōji Paipo Paipo Paipo no Shūringan Shūringan no Gūrindai Gūrindai no Ponpokopii no Ponpokonā no Chōkyūmei no Chōsuke*\nhttps://www.youtube.com/watch?v=x59kknMUPvQ\"" };
            int crng = rng.Next(chance.Length);
            string verd = chance[crng];
            await Context.Channel.SendMessageAsync(verd);
        }
    }
}
