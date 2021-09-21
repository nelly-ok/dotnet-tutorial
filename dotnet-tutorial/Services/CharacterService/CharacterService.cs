using dotnet_tutorial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_tutorial.Services.CharacterService
{
    public class CharacterService : ICharacterService

    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "Sam"}
        };
        
        public List<Character> GetAllCharacters()
        {
            return characters;
        }
        public Character GetCharacterById(int id)
        {
            return characters.First(c => c.Id == id);
        }
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }
    }
}