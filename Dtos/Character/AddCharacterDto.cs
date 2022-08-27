using dotnet_rpg.Models;

namespace dotnet_rpg.Dtos.Character;

public class AddCharacterDto
{
    public string Name { get; set; } = "Frodo";
    public RpgClass Class { get; set; } = RpgClass.Mage;
}