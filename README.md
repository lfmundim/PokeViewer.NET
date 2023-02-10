This is a trimmed down version of zyro670/PokeViewer.NET to feature **only** egg checking, as it is the only feature I was interested in. Any other functionality, including BDSP/SWSH/LPE compatibility was trimmed out. **Only compatible with SV**

<img width="397" alt="image" src="https://user-images.githubusercontent.com/15164001/217986176-2c0228fe-6b8a-4e0b-8a54-811ec9aafc5a.png">

Planned features:
* HA filter (post v1 release)
* auto export `.pk9` on shiny for backup (on hold, exported eggs from basket are illegal - no met conditions)
* Hystory and Statistics! (post v1 release)
* IV range filter (<5 instead of a specific number)

-----

Requirements:
- CFW.
- [SysBot.Base.](https://github.com/Koi-3088/sys-usb-botbase)
- .NET 7

-----

Supported Games:
- Scarlet / Violet

-----

How to use:
- Input your Switch IP in the field
- Click Connect
- Click Egg view
- Filter out what you want
    - Item # means how many Down presses needed to get to the desired ingredient
    - DUP means it presses UP instead of DOWN
    - Eat Again will automatically make a new sandwich after 2mins without new eggs or after 30mins
- Open picnic ingame, stay in a position where if you walk with Stick Up you would hit the table
- Wait until all animation is done
- Press fetch. Bot is up.

---

## Known Issues
* Sometimes connection with Sysbot can lag out and bot gets out of sync. **Workaround:** restart CFW
* Above issue might get into a scenario where I get SockedExceptions where the host closed the connection. **Workaround:** restart CFW
* Pokémon S/V doesn't erase egg date from basket once picnic is finished. This might result in false positives for shinies after getting a shiny on a picnic. A fix was issued on v0.1.0b_rev3 but it might happen. **Workaround:** reopen game.
    * **NOTE:** BE MINDFUL of the EC and PID of the shiny, theres always the chance of getting back to back shinies. If they are the same as the previous shiny you got it is a false positive.
* Sometimes you might get a false positive without getting any previous shiny. I currently know no workaround of source of the problem :( It uses PkHex shiny check so it should be accurate in theory.
