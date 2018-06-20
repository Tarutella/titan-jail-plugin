# Titan Jail ACT Plugin!

This plugin is used to call out player's position based on a priority list \

Download Jail_Plugin.dll\
https://github.com/Tarutella/titan-jail-plugin/releases/latest 

Example:
> Player1 < Jail\
> Player2 \
> Player3 \
> [ YOU ] < Jail \
> Player5 \
> Player6 \
> Player7 < Jail\
> Player8 \
the plugin will let you know that your position is second on the priority list.

## Steps:
1- Fill in priority list and select your character:\
![](https://i.gyazo.com/a4b45440d9638561bdc05ecca46d2a26.png)

2- Set up your Triggers:\
![](https://i.gyazo.com/b390d5b56d6730af4c34a60f9f1d96f1.png)

you can export and share the priority list with your team if they are following a priority system, or are using the plugin.
***


## How it works:
It will only call out if there are 3 log lines that match the regular expression\
`:[a-zA-Z-']+?:2B6(B|C):.*?:.*?:`\
of getting a Titan Gaol, within 1 second.

## How to test it:
Put these lines in a macro and run the macro. 

`15:4000596E:Garuda:2B6C:Rock Throw:106D93DF:A'oshane Taru`\
`15:4000596F:Garuda:2B6C:Rock Throw:1070B706:Akela Freya`\
`15:40005974:Titan:2B6B:Rock Throw:106966DD:Rai Lionheart`

Good Luck! :)
