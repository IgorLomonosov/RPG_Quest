# Main program
## Basic explanation of program
First of all it's a game, so you start with process of creation of your main character. It can be male or female with next races: elf, human and dwarf. Each race has its own special bonuses like additional health, defense or attack.
After MC creation you start your story. Game has fight mechanics, you even can die if you plan badly your moves in them and your adventure will be finished.
There is also inventory, where you can choose your weapon and armour, drink potions, check your potions' quantity and your wealth.
On the pre-final location there is shop, where you can buy the best armour and weapon in the game.
Game also has quests system and progress saving features.
Good luck in adventure called "Sweet Pudding".
## Programming Principles
### DRY
Principle DRY is used in [Entity Class](./ClassLibraryForWinForms/Entity.cs#L11-L38) in constructors with repeating code to initialize properties.
### KISS
Principle KISS is used in [Story Class](./ClassLibraryForWinForms/Story.cs#L9-L38) in simple checking of the game state  by using boolean properties.
### YAGNI
Principle YAGNI is used in [Story Class](./ClassLibraryForWinForms/Story.cs#L11-L22) in existence of needed properties for checking game state.
### Composition Over Inheritance
Principle Composition Over Inheritance is used in [MainCharacter Class](./ClassLibraryForWinForms/MainCharacter.cs#L12-L13) by using properties 'Weapon' and 'Armour' like objects of other Classes.
### Fail Fast
Principle Fail Fast is used in [MainCharacter Class](./ClassLibraryForWinForms/MainCharacter.cs#L57-L69) to check function for exception when number of 'PotionsHeld' equals '0'
## Design Patterns
### Singleton
Pattern Singleton is used in [Story Class](./ClassLibraryForWinForms/Story.cs#L42-L52) to make only one istance of object of Story Class at the time.
### Factory Method
Pattern Factory is used in creation of different quests in Classes [QuestFactory](./ClassLibraryForWinForms/QuestFactory.cs#L9-L12), [DefaultQuestFactory](./ClassLibraryForWinForms/DefaultQuestFactory.cs#L11-L15), [CustomQuestFactory](./ClassLibraryForWinForms/CustomQuestFactory.cs#L9-28).
### Strategy
Pattern Strategy is used in [MainCharacter Class](./ClassLibraryForWinForms/MainCharacter.cs#L29-L51) for attack and defense using [IAttackStrategy](./ClassLibraryForWinForms/IAttackStrategy.cs#L9-L20) and [IDefenseStrategy](./ClassLibraryForWinForms/IDefenseStrategy.cs#L9-L23) classes.
## Refactoring Techniques

