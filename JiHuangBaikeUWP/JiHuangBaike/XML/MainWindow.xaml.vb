Imports System.Windows.Interop
Imports System.Runtime.InteropServices
Imports IWshRuntimeLibrary '引用 WSH COM 类库
Imports Microsoft.Win32
Imports System.IO

Public Class MainWindow

    REM ------------------科技(工具)-------------------


    Private Sub button_S_machete_click(sender As Object, e As RoutedEventArgs) Handles button_S_machete.Click
        S_Show("砍刀", "Machete", "S_machete", "SW", 0, 1, 0, "G_twigs", "×1", "G_flint", "×3", "", "", 0, "", "用来砍竹子和藤蔓丛的必要工具，还可以切开鲸鱼的肚子，也可以用作武器。")
    End Sub

    Private Sub button_S_luxury_machete_click(sender As Object, e As RoutedEventArgs) Handles button_S_Luxury_machete.Click
        S_Show("黄金砍刀", "Luxury Machete", "S_luxury_machete", "SW", 0, 1, 0, "G_twigs", "×4", "S_gold_nugget", "×2", "", "", 2, "", "耐久度是普通砍刀的四倍。砍砍砍！")
    End Sub


    REM ------------------科技(照明)-------------------


    Private Sub button_S_chiminea_click(sender As Object, e As RoutedEventArgs) Handles button_S_chiminea.Click
        S_Show("室外壁炉", "Chiminea", "S_chiminea", "SW", 0, 1, 0, "S_limestone", "×2", "G_sand", "×2", "G_log", "×2", 0, "", "防风的壁炉，谁用谁知道！它不会让周围的物品燃烧，风季的时候熄灭得也更慢，防风必备！")
    End Sub


    Private Sub button_S_obsidian_fire_pit_click(sender As Object, e As RoutedEventArgs) Handles button_S_obsidian_fire_pit.Click
        S_Show("黑曜石火堆", "Obsidian Fire Pit", "S_obsidian_fire_pit", "SW", 0, 1, 0, "G_log", "×3", "G_obsidian", "×8", "", "", 2, "", "比营火的燃烧效率要高三倍，而且光照范围更大，免疫大风，不过会被淹没。")
    End Sub


    Private Sub button_S_bottle_lantern_click(sender As Object, e As RoutedEventArgs) Handles button_S_bottle_lantern.Click
        S_Show("水瓶提灯", "Bottle Lantern", "S_bottle_lantern", "SW", 0, 1, 0, "S_empty_bottle", "×1", "G_bioluminescence", "×2", "", "", 2, "", "船难版的提灯。可以用萤火虫、荧光果、粘滑含糊虫添加燃料。")
    End Sub

    Private Sub button_S_boat_torch_click(sender As Object, e As RoutedEventArgs) Handles button_S_boat_torch.Click
        S_Show("船载火炬", "Boat Torch", "S_boat_torch", "SW", 0, 1, 0, "G_twigs", "×2", "S_torch", "×1", "", "", 1, "", "顾名思义，船上用的火炬，不能给木筏和竹筏用，照明范围和火炬一样。")
    End Sub

    Private Sub button_S_boat_lantern_click(sender As Object, e As RoutedEventArgs) Handles button_S_boat_lantern.Click
        S_Show("船灯", "Boat Lantern", "S_boat_lantern", "SW", 0, 1, 0, "S_empty_bottle", "×1", "G_twigs", "×2", "G_fireflies", "×1", 1, "", "装在船上的水瓶提灯，照明范围很大。可以用萤火虫、荧光果、粘滑含糊虫添加燃料。")
    End Sub

    REM ------------------科技(航海)-------------------
    Private Sub button_S_surfboard_click(sender As Object, e As RoutedEventArgs) Handles button_S_surfboard.Click
        S_Show("冲浪板", "Surfboard", "S_surfboard", "SW", 0, 1, 0, "S_boards", "×1", "G_seashell", "×2", "", "", 0, "瓦拉尼", "瓦拉尼出生自带的冲浪板，是竹筏速度的1.3倍，手中可以拿工具，只有100点耐久度。骑乘波浪时会增加一点精神和五倍速度。可以冲浪！")
    End Sub

    Private Sub button_S_lucky_hat_click(sender As Object, e As RoutedEventArgs) Handles button_S_lucky_hat.Click
        S_Show("幸运帽", "Lucky Hat", "S_lucky_hat", "SW", 0, 1, 0, "S_cloth", "×3", "G_boneshard", "×4", "G_dubloons", "×10", 0, "伍德莱格", "伍德莱格出生自带的幸运帽，每800秒(约1天半，基于耐久)产生一个X标记的宝藏。如果不是由玩家穿戴则只有66%几率产生X标记。")
    End Sub

    Private Sub button_S_the_sea_legs_click(sender As Object, e As RoutedEventArgs) Handles button_S_the_sea_legs.Click
        S_Show("海腿号", "The 'Sea Legs'", "S_the_'sea_legs'", "SW", 0, 1, 0, "S_boat_cannon", "×1", "S_boards", "×4", "G_dubloons", "×4", 0, "伍德莱格", "伍德莱格出生自带的材料可以建造一艘海腿号，拥有500点耐久，自带船帆和无限使用的船载加农炮(只有50的伤害)。航行速度：6。")
    End Sub

    Private Sub button_S_log_raft_click(sender As Object, e As RoutedEventArgs) Handles button_S_log_raft.Click
        S_Show("木筏", "Log Raft", "S_log_raft", "SW", 0, 1, 0, "G_log", "×6", "G_cut_grass", "×4", "", "", 0, "", "拥有150点耐久度的最基本的船。航行速度：4。")
    End Sub

    Private Sub button_S_raft_click(sender As Object, e As RoutedEventArgs) Handles button_S_raft.Click
        S_Show("竹筏", "Raft", "S_raft", "SW", 0, 1, 0, "G_bamboo_patch", "×4", "G_vine", "×3", "", "", 0, "", "拥有150点耐久度，速度比木筏略快一些。航行速度：5。")
    End Sub

    Private Sub button_S_row_boat_click(sender As Object, e As RoutedEventArgs) Handles button_S_row_boat.Click
        S_Show("划艇", "Row Boat", "S_row_boat", "SW", 0, 1, 0, "S_boards", "×3", "G_vine", "×4", "", "", 1, "", "拥有250点耐久度，速度比竹筏更快一些，最重要的是可以装上武器/船灯和船帆了。航行速度：6。")
    End Sub

    Private Sub button_S_cargo_boat_click(sender As Object, e As RoutedEventArgs) Handles button_S_cargo_boat.Click
        S_Show("货船", "Cargo Boat", "S_cargo_boat", "SW", 0, 1, 0, "S_boards", "×6", "S_rope", "×3", "", "", 2, "", "拥有300点耐久度，可以装备武器/船灯和船帆，还有额外的六个物品栏。航行速度：5。")
    End Sub

    Private Sub button_S_armoured_boat_click(sender As Object, e As RoutedEventArgs) Handles button_S_armoured_boat.Click
        S_Show("装甲船", "Armoured Boat", "S_armoured_boat", "SW", 0, 1, 0, "S_boards", "×6", "S_rope", "×3", "G_seashell", "×10", 2, "", "拥有500点耐久度，耐久度最高的船，可以装备武器/船灯和船帆。航行速度：6。")
    End Sub

    Private Sub button_S_boat_repair_kit_click(sender As Object, e As RoutedEventArgs) Handles button_S_boat_repair_kit.Click
        S_Show("修船套件", "Boat Repair Kit", "S_boat_repair_kit", "SW", 0, 1, 0, "S_boards", "×2", "G_stinger", "×2", "S_rope", "×2", 1, "", "每次使用修复船100点耐久度，可以使用三次。")
    End Sub

    Private Sub button_S_thatch_sail_click(sender As Object, e As RoutedEventArgs) Handles button_S_thatch_sail.Click
        S_Show("草帆", "Thatch Sail", "S_thatch_sail", "SW", 0, 1, 0, "G_bamboo_patch", "×2", "G_vine", "×2", "G_palm_leaf", "×4", 1, "", "可以提高20%的航速，耐久性最低。只需要科学机器就可以建造。")
    End Sub

    Private Sub button_S_cloth_sail_click(sender As Object, e As RoutedEventArgs) Handles button_S_cloth_sail.Click
        S_Show("布帆", "Cloth Sail", "S_cloth_sail", "SW", 0, 1, 0, "G_bamboo_patch", "×2", "S_rope", "×2", "S_cloth", "×2", 2, "", "可以提高30%的航速，耐久性中等，需要炼金术引擎才能建造。")
    End Sub

    Private Sub button_S_snakeskin_sail_click(sender As Object, e As RoutedEventArgs) Handles button_S_snakeskin_sail.Click
        S_Show("蛇皮帆", "Snakeskin Sail", "S_snakeskin_sail", "SW", 0, 1, 0, "G_log", "×4", "S_rope", "×2", "G_snakeskin", "×2", 2, "", "耐久性最高，然而速度在草帆和布帆之间，比较适合长途旅行。")
    End Sub

    Private Sub button_S_feather_lite_sail_click(sender As Object, e As RoutedEventArgs) Handles button_S_feather_lite_sail.Click
        S_Show("简版羽帆", "Feather Lite Sail", "S_feather_lite_sail", "SW", 0, 1, 0, "G_bamboo_patch", "×2", "S_rope", "×2", "G_doydoy_feather", "×4", 1, "", "可以提高40%的航速，但是耐久性和草帆相当。")
    End Sub

    Private Sub button_S_iron_wind_click(sender As Object, e As RoutedEventArgs) Handles button_S_iron_wind.Click
        S_Show("铁风牌发动机", "Iron Wind", "S_iron_wind", "SW", 0, 1, 0, "G_turbine_blades", "×1", "S_electrical_doodad", "×1", "S_gold_nugget", "×2", 2, "", "可以提高50%的航速，耐久性也最高，然而为了获得材料涡轮叶片必须打败豹卷风。只能通过齿轮修复，一个齿轮修复25%耐久度。")
    End Sub

    Private Sub button_S_boat_cannon_click(sender As Object, e As RoutedEventArgs) Handles button_S_boat_cannon.Click
        S_Show("船载加农炮", "Boat Cannon", "S_boat_cannon", "SW", 0, 1, 0, "G_log", "×5", "S_gunpowder", "×4", "F_coconut", "×6", 1, "", "每炮都能造成100点伤害，总共可以射出15炮。")
    End Sub

    Private Sub button_S_sea_trap_click(sender As Object, e As RoutedEventArgs) Handles button_S_sea_trap.Click
        S_Show("海洋陷阱", "Sea Trap", "S_sea_trap", "SW", 0, 1, 0, "G_palm_leaf", "×4", "S_empty_bottle", "×2", "A_jellyfish", "×1", 1, "", "捉龙虾就靠它！")
    End Sub

    Private Sub button_S_trawl_net_click(sender As Object, e As RoutedEventArgs) Handles button_S_trawl_net.Click
        S_Show("拖网", "Trawl Net", "S_trawl_net", "SW", 0, 1, 0, "S_rope", "×3", "G_bamboo_patch", "×2", "", "", 1, "", "挂在船后拖一段时间就可以随机获得九样东西。")
    End Sub

    Private Sub button_S_spyglass_click(sender As Object, e As RoutedEventArgs) Handles button_S_spyglass.Click
        S_Show("望远镜", "Spyglass", "S_spyglass", "SW", 0, 1, 0, "S_empty_bottle", "×1", "G_pig_skin", "×1", "S_gold_nugget", "×1", 1, "", "通过点击右键看到远处的东西。距离受到时间的影响，白天最远，在船上或者风季距离都会减小。可以发现X标记的宝箱。")
    End Sub

    Private Sub button_S_super_spyglass_click(sender As Object, e As RoutedEventArgs) Handles button_S_super_spyglass.Click
        S_Show("EX望远镜", "Super Spyglass", "S_super_spyglass", "SW", 0, 1, 0, "S_spyglass", "×1", "F_eye_of_the_tiger_shark", "×1", "S_gold_nugget", "×1", 1, "", "距离是望远镜的两倍，可以被大风吹走。")
    End Sub

    Private Sub button_S_captain_hat_click(sender As Object, e As RoutedEventArgs) Handles button_S_captain_hat.Click
        S_Show("船长帽", "Captain Hat", "S_captain_hat", "SW", 0, 1, 0, "F_seaweed", "×1", "G_boneshard", "×1", "S_straw_hat", "×1", 1, "", "戴上会使船的航行耐久度消耗减半。当个船长去冒险！")
    End Sub

    Private Sub button_S_pirate_hat_click(sender As Object, e As RoutedEventArgs) Handles button_S_pirate_hat.Click
        S_Show("海盗帽", "Pirate Hat", "S_pirate_hat", "SW", 0, 1, 0, "G_boneshard", "×2", "S_rope", "×1", "G_silk", "×2", 1, "", "航行时戴上它会增加地图显示范围，缓慢恢复精神。")
    End Sub

    Private Sub button_S_life_jacket_click(sender As Object, e As RoutedEventArgs) Handles button_S_life_jacket.Click
        S_Show("救生衣", "Life Jacket", "S_life_jacket", "SW", 0, 1, 0, "S_cloth", "×2", "G_vine", "×2", "S_empty_bottle", "×3", 1, "", "穿上救生衣，不怕翻船！当船的耐久度降为0后，屏幕会逐渐变黑，玩家出现在最近的船难上，并且拥有足够的草和木头制作木筏。")
    End Sub

    Private Sub button_S_buoy_click(sender As Object, e As RoutedEventArgs) Handles button_S_buoy.Click
        S_Show("浮标", "Buoy", "S_buoy", "SW", 0, 1, 0, "S_empty_bottle", "×1", "G_bamboo_patch", "×4", "G_bioluminescence", "×2", 1, "", "放在海上提供比火炬更亮的光，不需要添加燃料。")
    End Sub

    REM ------------------科技(生存)-------------------
    Private Sub button_S_chef_pouch_click(sender As Object, e As RoutedEventArgs) Handles button_S_chef_pouch.Click
        S_Show("厨师的袋子", "Chef Pouch", "S_chef_pouch", "SW", 0, 1, 0, "S_cloth", "×1", "S_rope", "×1", "", "", 0, "沃利", "沃利特有的8格隔热包！作用和冰箱类似可以让食物变质变缓慢，但是和冰箱不同的是不能阻止冰块变质，也不能冷却热能石。")
    End Sub

    Private Sub button_S_silly_monkey_ball_click(sender As Object, e As RoutedEventArgs) Handles button_S_silly_monkey_ball.Click
        S_Show("傻猴子球", "Silly Monkey Ball", "S_silly_monkey_ball", "SW", 0, 1, 0, "G_snakeskin", "×2", "F_banana", "×1", "S_rope", "×2", 2, "", "傻猴子们，玩球儿去~")
    End Sub

    Private Sub button_S_tropical_parasol_click(sender As Object, e As RoutedEventArgs) Handles button_S_tropical_parasol.Click
        S_Show("热带遮阳伞", "Tropical Parasol", "S_tropical_parasol", "SW", 0, 1, 0, "G_twigs", "×4", "G_palm_leaf", "×3", "G_petals", "×6", 0, "", "船难版的漂亮太阳伞，防止潮湿和过热。无论是否装备上都会消耗耐久。")
    End Sub

    Private Sub button_S_anti_venom_click(sender As Object, e As RoutedEventArgs) Handles button_S_anti_venom.Click
        S_Show("抗蛇毒血清", "Anti Venom", "S_anti_venom", "SW", 0, 1, 0, "G_venom_gland", "×1", "F_seaweed", "×3", "G_coral", "×2", 1, "", "中毒了用什么？抗蛇毒血清！治疗那种不舒服的中毒感。")
    End Sub

    Private Sub button_S_thatch_pack_click(sender As Object, e As RoutedEventArgs) Handles button_S_thatch_pack.Click
        S_Show("茅草包", "Thatch Pack", "S_thatch_pack", "SW", 0, 1, 0, "G_palm_leaf", "×4", "", "", "", "", 0, "", "只能增加4格物品栏，大概没有更小的包了。唯一的好处是不需要科技就能做。")
    End Sub

    Private Sub button_S_palm_leaf_hut_click(sender As Object, e As RoutedEventArgs) Handles button_S_palm_leaf_hut.Click
        S_Show("椰叶小屋", "Palm Leaf Hut", "S_palm_leaf_hut", "SW", 0, 1, 0, "G_palm_leaf", "×4", "G_bamboo_patch", "×4", "S_rope", "×3", 2, "", "待在椰叶小屋下，不会被雨淋，不会过热。小屋没有耐久，尽管其外表脆弱，然而不会受到大风的影响。小屋的保护区域比看起来要大一些。")
    End Sub

    Private Sub button_S_tropical_fan_click(sender As Object, e As RoutedEventArgs) Handles button_S_tropical_fan.Click
        S_Show("热带风扇", "Tropical Fan", "S_tropical_fan", "SW", 0, 1, 0, "G_doydoy_feather", "×5", "G_cut_reeds", "×2", "S_rope", "×2", 2, "", "扇一下会让玩家温度降低50°，但最低不会低于5°。会扑灭周围的火！可以使用15次。")
    End Sub

    Private Sub button_S_sea_sack_click(sender As Object, e As RoutedEventArgs) Handles button_S_sea_sack.Click
        S_Show("海上麻袋", "Sea Sack", "S_sea_sack", "SW", 0, 1, 0, "G_cut_reeds", "×5", "G_vine", "×2", "G_shark_gills", "×1", 2, "", "船难版的隔热包。只有6个格子的背包，但是作用和冰箱类似可以让食物变质变缓慢，但是和冰箱不同的是不能阻止冰块变质，也不能冷却热能石。")
    End Sub

    Private Sub button_S_doydoy_nest_click(sender As Object, e As RoutedEventArgs) Handles button_S_doydoy_nest.Click
        S_Show("渡渡鸟巢", "Doydoy Nest", "S_doydoy_nest", "SW", 0, 1, 0, "G_twigs", "×8", "G_doydoy_feather", "×2", "G_manure", "×4", 2, "", "建造一个渡渡鸟巢来孵小渡渡鸟~")
    End Sub

    REM ------------------科技(食物)-------------------
    Private Sub button_S_mussel_stick_click(sender As Object, e As RoutedEventArgs) Handles button_S_mussel_stick.Click
        S_Show("采贝器", "Mussel Stick", "S_mussel_stick", "SW", 0, 1, 0, "G_bamboo_patch", "×2", "G_vine", "×1", "F_seaweed", "×1", 1, "", "插在贻贝床上可以采贝，时间越久采的贻贝越多，最多六个。")
    End Sub

    REM ------------------科技(科学)-------------------
    Private Sub button_S_ice_maker_3000_click(sender As Object, e As RoutedEventArgs) Handles button_S_ice_maker_3000.Click
        S_Show("造冰机 3000 plus", "Ice Maker 3000", "S_ice_maker_3000", "SW", 0, 1, 0, "S_thermal_stone", "×1", "G_bamboo_patch", "×5", "S_electrical_doodad", "×2", 2, "", "用燃料换冰。每30秒产生一个冰，最多3个，一旦开始生产就不能停下，燃料添加过多也不会有多余的冰。被建造时会持续生产45秒(即一个半冰)。剩余30秒时若燃料不够则会浪费剩余的燃料。")
    End Sub


    REM ------------------科技(战斗)-------------------
    Private Sub button_S_poison_spear_click(sender As Object, e As RoutedEventArgs) Handles button_S_poison_spear.Click
        S_Show("毒矛", "Poison Spear", "S_poison_spear", "SW", 0, 1, 0, "S_spear", "×1", "G_venom_gland", "×1", "", "", 1, "", "和长矛的攻击力相当，中毒的敌人攻速移速将会变慢，攻击力降低，然而收获的食材保鲜度将下降为原本的一半。")
    End Sub

    Private Sub button_S_seashell_suit_click(sender As Object, e As RoutedEventArgs) Handles button_S_seashell_suit.Click
        S_Show("海贝盔甲", "Seashell Suit", "S_seashell_suit", "SW", 0, 1, 0, "G_seashell", "×10", "F_seaweed", "×2", "S_rope", "×1", 1, "", "吸收大部分的伤害，防止被毒蛇、毒蚊、蜘蛛战士攻击时中毒。")
    End Sub

    Private Sub button_S_limestone_suit_click(sender As Object, e As RoutedEventArgs) Handles button_S_limestone_suit.Click
        S_Show("石灰石盔甲", "Limestone Suit", "S_limestone_suit", "SW", 0, 1, 0, "S_limestone", "×3", "S_rope", "×2", "", "", 2, "", "吸收大量伤害，每分钟回复2点精神，但是会减少10%的速度。")
    End Sub

    Private Sub button_S_cactus_armour_click(sender As Object, e As RoutedEventArgs) Handles button_S_cactus_armour.Click
        S_Show("象仙人掌盔甲", "Cactus Armour", "S_cactus_armour", "SW", 0, 1, 0, "G_cactus_spike", "×3", "S_log_suit", "×1", "", "", 2, "", "防御力很高，每次受到攻击都会反弹17点伤害，使象仙人掌无视玩家并且免疫来自象仙人掌的攻击。")
    End Sub

    Private Sub button_S_horned_helmet_click(sender As Object, e As RoutedEventArgs) Handles button_S_horned_helmet.Click
        S_Show("角状头盔", "Horned Helmet", "S_horned_helmet", "SW", 0, 1, 0, "G_horn", "×1", "G_seashell", "×4", "S_rope", "×1", 2, "", "防御力极高，有一定防水功效，还能防止被毒蛇、毒蚊、蜘蛛战士攻击时中毒。")
    End Sub

    Private Sub button_S_poison_dart_click(sender As Object, e As RoutedEventArgs) Handles button_S_poison_dart.Click
        S_Show("毒镖", "Poison Dart", "S_poison_dart", "SW", 0, 1, 0, "G_cut_reeds", "×2", "G_venom_gland", "×1", "G_jet_feather", "×1", 1, "", "一次性武器，在两分钟内每十秒毒两点血，共造成二十六点伤害。如果生物被毒死食材会变得不新鲜。")
    End Sub

    Private Sub button_S_coconade_click(sender As Object, e As RoutedEventArgs) Handles button_S_coconade.Click
        S_Show("椰壳炸弹", "Coconade", "S_coconade", "SW", 0, 1, 0, "F_coconut", "×1", "S_gunpowder", "×1", "S_rope", "×1", 1, "", "可以放在地上点燃又可以点燃后丢出去的炸弹，造成250点伤害。")
    End Sub

    Private Sub button_S_spear_gun_click(sender As Object, e As RoutedEventArgs) Handles button_S_spear_gun.Click
        S_Show("矛枪", "Spear Gun", "S_spear_gun", "SW", 0, 1, 0, "G_bamboo_patch", "×3", "A_jellyfish", "×1", "", "", 1, "", "可以装载长矛、战斗长矛、毒矛、黑曜石矛，射出去造成三倍伤害。射出的矛需重新拾起填装。一个矛枪可以使用八次。")
    End Sub

    Private Sub button_S_cutlass_supreme_click(sender As Object, e As RoutedEventArgs) Handles button_S_cutlass_supreme.Click
        S_Show("旗鱼短剑", "Cutlass Supreme", "S_cutlass_supreme", "SW", 0, 1, 0, "G_dead_swordfish", "×1", "S_gold_nugget", "×2", "G_twigs", "×1", 2, "", "拥有高额的伤害，对豹卷风还能造成1.5倍伤害加成。攻击力虽高可是需要旗鱼。")
    End Sub

    REM ------------------科技(建筑)-------------------
    Private Sub button_S_limestone_wall_click(sender As Object, e As RoutedEventArgs) Handles button_S_limestone_wall.Click
        S_Show("石灰石墙", "Limestone Wall", "S_limestone_wall", "SW", 0, 1, 0, "S_limestone", "×2", "", "", "", "", 2, "", "可放置围墙，每份250生命，可叠加放置，最高500，珊瑚还算比较多，有时间的话可以造一些。")
    End Sub

    Private Sub button_S_wildbore_house_click(sender As Object, e As RoutedEventArgs) Handles button_S_wildbore_house.Click
        S_Show("荒野小屋", "Wildbore House", "S_wildbore_house", "SW", 0, 1, 0, "G_bamboo_patch", "×8", "G_palm_leaf", "5", "G_pig_skin", "×4", 2, "", "建造一个荒野小屋，类似猪舍，不过当你拆荒野小屋的时候野猪会试图保护它。")
    End Sub

    Private Sub button_S_prime_ape_hut_click(sender As Object, e As RoutedEventArgs) Handles button_S_prime_ape_hut.Click
        S_Show("猿猴小屋", "Prime Ape Hut", "S_prime_ape_hut", "SW", 0, 1, 0, "G_twigs", "×10", "F_banana", "×3", "G_manure", "×4", 2, "", "建造一个猿猴小屋，最多产生四只猿。猿被击杀后新的猿将会在短时间内重生。")
    End Sub

    Private Sub button_S_dragoon_den_click(sender As Object, e As RoutedEventArgs) Handles button_S_dragoon_den.Click
        S_Show("龙人巢", "Dragoon Den", "S_dragoon_den", "SW", 0, 1, 0, "G_dragoon_heart", "×1", "G_rocks", "×5", "G_obsidian", "×4", 2, "", "建造一个龙人巢，产生3到4只龙人。不能用锤子摧毁，只能用火药或椰壳炸弹炸毁。")
    End Sub

    Private Sub button_S_snakeskin_rug_click(sender As Object, e As RoutedEventArgs) Handles button_S_snakeskin_rug.Click
        S_Show("蛇皮地毯", "Snakeskin Rug", "S_snakeskin_rug", "SW", 0, 1, 0, "G_snakeskin", "×2", "S_cloth", "×1", "", "", 2, "", "可放置地皮，不会产生水坑，然而无法阻止潮汐和洪水。")
    End Sub

    Private Sub button_S_sandbag_click(sender As Object, e As RoutedEventArgs) Handles button_S_sandbag.Click
        S_Show("沙袋", "SandBag", "S_sandbag", "SW", 0, 1, 0, "S_cloth", "×2", "G_sand", "×3", "", "", 1, "", "阻止洪水、填充水坑就靠它！每份200点生命。")
    End Sub

    Private Sub button_S_sand_castle_click(sender As Object, e As RoutedEventArgs) Handles button_S_sand_castle.Click
        S_Show("沙雕", "Sand Castle", "S_sand_castle", "SW", 0, 1, 0, "G_sand", "×4", "G_palm_leaf", "×2", "G_seashell", "×3", 0, "", "沙雕嘛，当然只能建在沙滩上啦！站在周围会增加精神，只会持续一天。一天结束后会变成沙子、贝壳和椰树叶各一个。")
    End Sub

    REM ------------------科技(合成)-------------------
    Private Sub button_S_cloth_click(sender As Object, e As RoutedEventArgs) Handles button_S_cloth.Click
        S_Show("布", "Cloth", "S_cloth", "SW", 0, 1, 0, "G_bamboo_patch", "×3", "", "", "", "", 1, "", "高级素材，可以做一些衣物。")
    End Sub

    Private Sub button_S_limestone_click(sender As Object, e As RoutedEventArgs) Handles button_S_limestone.Click
        S_Show("石灰石", "Limestone", "S_limestone", "SW", 0, 1, 0, "G_coral", "×3", "", "", "", "", 1, "", "高级素材，一些建筑要用到石灰石。")
    End Sub

    Private Sub button_S_gold_nugget_click(sender As Object, e As RoutedEventArgs) Handles button_S_gold_nugget.Click
        S_Show("金块", "Gold Nugget", "S_gold_nugget", "SW", 0, 1, 0, "G_dubloons", "×3", "", "", "", "", 1, "", "船难中金块不多，可以用金币合成一些。")
    End Sub

    Private Sub button_S_ice_click(sender As Object, e As RoutedEventArgs) Handles button_S_ice.Click
        S_Show("冰", "Ice", "S_ice", "SW", 0, 1, 0, "G_hail", "×4", "", "", "", "", 2, "", "船难中的冰比较缺少，可以用冰雹合成。")
    End Sub

    Private Sub button_S_empty_bottle_click(sender As Object, e As RoutedEventArgs) Handles button_S_empty_bottle.Click
        S_Show("空瓶子", "Empty Bottle", "S_empty_bottle", "SW", 0, 1, 0, "G_sand", "×3", "", "", "", "", 2, "", "高级素材，可以制作灯等。")
    End Sub

    Private Sub button_S_nightmare_fuel_click(sender As Object, e As RoutedEventArgs) Handles button_S_nightmare_fuel.Click
        S_Show("噩梦燃料", "Nightmare Fuel", "S_nightmare_fuel", "NoDLC", 1, 1, 1, "G_dark_petals", "×3", "", "", "", "", 3, "", "高级素材，可以用来制作梦魇装备，或者为暗影灯添加燃料。")
    End Sub

    Private Sub button_S_purple_gem_click(sender As Object, e As RoutedEventArgs) Handles button_S_purple_gem.Click
        S_Show("紫宝石", "Purple Gem", "S_purple_gem", "NoDLC", 1, 1, 1, "G_red_gem", "×1", "G_blue_gem", "×1", "", "", 3, "", "高级素材，可以用来合成暗影操纵仪等道具。")
    End Sub

    REM ------------------科技(魔法)-------------------
    Private Sub button_S_dripple_pipes_click(sender As Object, e As RoutedEventArgs) Handles button_S_dripple_pipes.Click
        S_Show("滴水的长管", "Dripple Pipes", "S_dripple_pipes", "SW", 0, 1, 0, "G_horn", "×1", "G_nightmare_fuel", "×2", "S_rope", "×1", 8, "", "冬天使用会下雪，其他时候使用会下小雨。改变天气的奇妙物品。")
    End Sub

    Private Sub button_S_old_bell_click(sender As Object, e As RoutedEventArgs) Handles button_S_old_bell.Click
        S_Show("旧钟", "Old Bell", "S_old_bell", "ROG", 1, 0, 0, "G_glommer's_wings", "×1", "G_glommer's_flower", "×1", "", "", 0, "", "蓝图需用鹤嘴锄砸格罗姆雕像获得。使用后过几秒会有一个长满鳞片的大脚，能砍伐树木、挖矿等，造成一千点伤害。在洞穴使用则会引发地震。")
        SL_TextBlock_ScienceDeblocking_Science.Visibility = Visibility.Visible
        SL_TextBlock_ScienceDeblocking_Science.Text = "蓝图解锁"
        SL_TextBlock_ScienceDeblocking_Science.Foreground = Brushes.CadetBlue
        SL_TextBlock_ScienceDeblocking_Science.UpdateLayout()
        SL_TextBlock_ScienceDeblocking_Science.SetValue(Canvas.LeftProperty, CDbl((Canvas_ScienceLeft.ActualWidth - SL_TextBlock_ScienceDeblocking_Science.ActualWidth) / 2))
    End Sub

    Private Sub button_S_seaworthy_click(sender As Object, e As RoutedEventArgs) Handles button_S_seaworthy.Click
        S_Show("海之船送", "Seaworthy", "S_Seaworthy", "ROG", 1, 0, 0, "G_nightmare_fuel", "×4", "G_living_log", "×4", "T_sea_worther", "×1", 4, "", "从船难版通过海之船送穿越后，魔法科技就会多出一个海之船送，用以穿越回船难。其中沃尔特海需要用锤子砸掉沉船获得。")
    End Sub

    REM ------------------科技(衣物)-------------------
    Private Sub button_S_brain_of_thought_click(sender As Object, e As RoutedEventArgs) Handles button_S_brain_of_thought.Click
        S_Show("智慧帽", "Brain of Thought", "S_brain_of_thought", "SW", 0, 1, 0, "F_brainy_matter", "×1", "A_jellyfish", "×1", "S_rope", "×2", 2, "", "谁最聪明吖？戴上它可以制作四次任何可合成的物品而不需要科技，但是不会解锁该物品的配方。")
    End Sub

    Private Sub button_S_shark_tooth_crown_click(sender As Object, e As RoutedEventArgs) Handles button_S_shark_tooth_crown.Click
        S_Show("鲨齿王冠", "Shark Tooth Crown", "S_shark_tooth_crown", "SW", 0, 1, 0, "G_hound's_tooth", "×5", "S_gold_nugget", "×1", "", "", 1, "", "在船上戴上它每分钟恢复6.6精神。金灿灿的牙齿高贵身份显露无疑。")
    End Sub

    Private Sub button_S_snakeskin_hat_click(sender As Object, e As RoutedEventArgs) Handles button_S_snakeskin_hat.Click
        S_Show("蛇鳞帽", "Snakeskin Hat", "S_snakeskin_hat", "SW", 0, 1, 0, "G_snakeskin", "×1", "S_straw_hat", "×1", "G_boneshard", "×1", 2, "", "防止70%的湿度增加，还能防雷防水母触电，简直就是戴在头上的避雷针！")
    End Sub

    Private Sub button_S_snakeskin_jacket_click(sender As Object, e As RoutedEventArgs) Handles button_S_snakeskin_jacket.Click
        S_Show("蛇鳞上衣", "Snakeskin Jacket", "S_snakeskin_jacket", "SW", 0, 1, 0, "G_snakeskin", "×2", "G_vine", "×2", "G_boneshard", "×2", 1, "", "和蛇鳞帽效果一样，另外还具有较差的保暖功能，和兔毛耳套差不多。")
    End Sub

    Private Sub button_S_blubber_suit_click(sender As Object, e As RoutedEventArgs) Handles button_S_blubber_suit.Click
        S_Show("鲸脂套装", "Blubber Suit", "S_blubber_suit", "SW", 0, 1, 0, "F_blubber", "×4", "S_cloth", "×2", "G_palm_leaf", "×2", 2, "", "完全免疫水和雨！保暖功效和牛帽一样！")
    End Sub

    Private Sub button_S_floral_shirt_click(sender As Object, e As RoutedEventArgs) Handles button_S_floral_shirt.Click
        S_Show("花纹衬衫", "Floral Shirt", "S_floral_shirt", "NoDLC", 1, 1, 1, "S_papyrus", "×3", "G_silk", "×3", "F_cactus_flower", "×5", 2, "", "夏天用来减缓温度上升的衣服，虽然效果不大，总比带负面效果的冰块要好一点吧。不能用缝纫工具包修补。在船难版里制作材料仙人掌花改为花瓣。")
    End Sub

    Private Sub button_S_dumbrella_click(sender As Object, e As RoutedEventArgs) Handles button_S_dumbrella.Click
        S_Show("双层伞帽", "Dumbrella", "S_dumbrella", "SW", 0, 1, 0, "G_shark_gills", "×2", "S_umbrella", "×1", "S_straw_hat", "×1", 2, "", "像眼球伞一样防水防雷还延缓过热，可以空出双手来工作，非常方便。")
    End Sub

    Private Sub button_S_windbreaker_click(sender As Object, e As RoutedEventArgs) Handles button_S_windbreaker.Click
        S_Show("风衣", "Windbreaker", "S_windbreaker", "SW", 0, 1, 0, "F_blubber", "×2", "S_cloth", "×1", "S_rope", "×1", 2, "", "20%防水，并且防止被大风吹跑，穿上后还会减小被豹卷风卷影响的半径。")
    End Sub

    Private Sub button_S_particulate_purifier_click(sender As Object, e As RoutedEventArgs) Handles button_S_particulate_purifier.Click
        S_Show("粉尘净化器", "Particulate Purifier", "S_particulate_purifier", "SW", 0, 1, 0, "S_empty_bottle", "×2", "G_coral", "×3", "A_jellyfish", "×1", 2, "", "戴上它就可以免疫毒洞和恶臭魔鬼鱼的毒！机器人戴上它大概是为了臭美一下吧？")
    End Sub

    Private Sub button_S_sleek_hat_click(sender As Object, e As RoutedEventArgs) Handles button_S_sleek_hat.Click
        S_Show("星芒头盔", "Sleek Hat", "S_sleek_hat", "SW", 0, 1, 0, "G_shark_fin", "×1", "G_vine", "×2", "F_coconut", "×1", 2, "", "增加25%的移动速度，和步行手杖一样。还能抵御些许风！")
    End Sub

    REM ------------------科技(远古)-------------------

    REM ------------------科技(书)-------------------
    Private Sub button_S_joy_of_volcanology_click(sender As Object, e As RoutedEventArgs) Handles button_S_joy_of_volcanology.Click
        S_Show("欢乐的火山", "Joy Of Volcanology", "S_joy_of_volcanology", "SW", 0, 1, 0, "S_papyrus", "×2", "G_obsidian", "×2", "", "", 3, "维克波顿", "在玩家位置落下四个龙人蛋(不会保存完整)。阅读书籍不会降低精神，维克波顿专有，可使用5次。")
    End Sub

    REM ------------------科技(暗影巫术)-------------------

    REM ------------------科技(火山)-------------------
    Private Sub button_S_obsidian_machete_click(sender As Object, e As RoutedEventArgs) Handles button_S_obsidian_machete.Click
        S_Show("黑曜石砍刀", "Obsidian Machete", "S_obsidian_machete", "SW", 0, 1, 0, "S_machete", "×1", "G_obsidian", "×3", "G_dragoon_heart", "×1", 9, "", "挥砍更有效率。拥有29点攻击力，如果充能能打出连击。除了风季，会逐渐充能，能量和第二击伤害(最高29)成正比。过度充能会导致攻击的目标燃烧。充能还会发光发热，会导致过热。")
    End Sub

    Private Sub button_S_obsidian_axe_click(sender As Object, e As RoutedEventArgs) Handles button_S_obsidian_axe.Click
        S_Show("黑曜石斧", "Obsidian Axe", "S_obsidian_axe", "SW", 0, 1, 0, "S_axe", "×1", "G_obsidian", "×2", "G_dragoon_heart", "×1", 9, "", "砍树效率是普通斧头的2.5倍。和黑曜石砍刀一样会充能。")
    End Sub

    Private Sub button_S_obsidian_spear_click(sender As Object, e As RoutedEventArgs) Handles button_S_obsidian_spear.Click
        S_Show("黑曜石矛", "Obsidian Spear", "S_obsidian_spear", "SW", 0, 1, 0, "S_spear", "×1", "G_obsidian", "×3", "G_dragoon_heart", "×1", 9, "", "拥有51点攻击力，充满能后攻击将会达到102点。")
    End Sub

    Private Sub button_S_volcano_staff_click(sender As Object, e As RoutedEventArgs) Handles button_S_volcano_staff.Click
        S_Show("熔岩法杖", "Volcano Staff", "S_volcano_staff", "SW", 0, 1, 0, "S_fire_staff", "×1", "G_obsidian", "×4", "G_dragoon_heart", "×1", 9, "", "施放符咒会导致下龙人蛋雨，不同于天然的火山喷发，没有机会保留完整的龙人蛋。")
    End Sub

    Private Sub button_S_obsidian_armour_click(sender As Object, e As RoutedEventArgs) Handles button_S_obsidian_armour.Click
        S_Show("黑曜石盔甲", "Obsidian Armour", "S_obsidian_armour", "SW", 0, 1, 0, "S_log_suit", "×1", "G_obsidian", "×5", "G_dragoon_heart", "×1", 9, "", "类似鳞甲，然而不会恢复精神，而且耐久度也只有鳞甲的四分之三。")
    End Sub

    Private Sub button_S_obsidian_coconade_click(sender As Object, e As RoutedEventArgs) Handles button_S_obsidian_coconade.Click
        S_Show("黑曜石炸弹", "Obsidian Coconade", "S_obsidian_coconade", "SW", 0, 1, 0, "S_coconade", "×3", "G_obsidian", "×3", "G_dragoon_heart", "×1", 9, "", "类似椰壳炸弹，不过威力更大，能造成340点伤害，而且一次制造三个。")
    End Sub

    Private Sub button_S_howling_conch_click(sender As Object, e As RoutedEventArgs) Handles button_S_howling_conch.Click
        S_Show("呼啸的海螺", "Howling Conch", "S_howling_conch", "SW", 0, 1, 0, "G_obsidian", "×4", "S_purple_gem", "×1", "G_magic_seal", "×1", 9, "", "使用后会开始持续半天的强风，如果在巨人的统治里使用则会变成降雨。")
    End Sub

    Private Sub button_S_sail_stick_click(sender As Object, e As RoutedEventArgs) Handles button_S_sail_stick.Click
        S_Show("帆棍", "Sail Stick", "S_sail_stick", "SW", 0, 1, 0, "G_obsidian", "×2", "G_nightmare_fuel", "×3", "G_magic_seal", "×1", 9, "", "改变风向的神器道具，装备着帆棍无论怎么走都是顺风！")
    End Sub

#Region "模拟"
    REM ------------------添加食材按钮-------------------
    REM ------------------食材(肉类)-------------------
    Private Sub button_CS_eel_click(sender As Object, e As RoutedEventArgs) Handles button_CS_eel.Click
        CS_Add("F_eel")
    End Sub

    Private Sub button_CS_cooked_eel_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_eel.Click
        CS_Add("F_cooked_eel")
    End Sub

    Private Sub button_CS_fish_click(sender As Object, e As RoutedEventArgs) Handles button_CS_fish.Click
        CS_Add("F_fish")
    End Sub

    Private Sub button_CS_cooked_fish_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_fish.Click
        CS_Add("F_cooked_fish")
    End Sub

    Private Sub button_CS_frog_legs_click(sender As Object, e As RoutedEventArgs) Handles button_CS_frog_legs.Click
        CS_Add("F_frog_legs")
    End Sub

    Private Sub button_CS_cooked_frog_legs_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_frog_legs.Click
        CS_Add("F_cooked_frog_legs")
    End Sub

    Private Sub button_CS_meat_click(sender As Object, e As RoutedEventArgs) Handles button_CS_meat.Click
        CS_Add("F_meat")
    End Sub

    Private Sub button_CS_cooked_meat_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_meat.Click
        CS_Add("F_cooked_meat")
    End Sub

    Private Sub button_CS_jerky_click(sender As Object, e As RoutedEventArgs) Handles button_CS_jerky.Click
        CS_Add("F_jerky")
    End Sub

    Private Sub button_CS_monster_meat_click(sender As Object, e As RoutedEventArgs) Handles button_CS_monster_meat.Click
        CS_Add("F_monster_meat")
    End Sub

    Private Sub button_CS_cooked_monster_meat_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_monster_meat.Click
        CS_Add("F_cooked_monster_meat")
    End Sub

    Private Sub button_CS_monster_jerky_click(sender As Object, e As RoutedEventArgs) Handles button_CS_monster_jerky.Click
        CS_Add("F_monster_jerky")
    End Sub

    Private Sub button_CS_morsel_click(sender As Object, e As RoutedEventArgs) Handles button_CS_morsel.Click
        CS_Add("F_morsel")
    End Sub

    Private Sub button_CS_cooked_morsel_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_morsel.Click
        CS_Add("F_cooked_morsel")
    End Sub

    Private Sub button_CS_small_jerky_click(sender As Object, e As RoutedEventArgs) Handles button_CS_small_jerky.Click
        CS_Add("F_small_jerky")
    End Sub

    Private Sub button_CS_drumstick_click(sender As Object, e As RoutedEventArgs) Handles button_CS_drumstick.Click
        CS_Add("F_drumstick")
    End Sub

    Private Sub button_CS_fried_drumstick_click(sender As Object, e As RoutedEventArgs) Handles button_CS_fried_drumstick.Click
        CS_Add("F_fried_drumstick")
    End Sub

    Private Sub button_CS_moleworm_click(sender As Object, e As RoutedEventArgs) Handles button_CS_moleworm.Click
        CS_Add("F_moleworm")
    End Sub

    Private Sub button_CS_tropical_fish_click(sender As Object, e As RoutedEventArgs) Handles button_CS_tropical_fish.Click
        CS_Add("F_tropical_fish")
    End Sub

    Private Sub button_CS_fish_morsel_click(sender As Object, e As RoutedEventArgs) Handles button_CS_fish_morsel.Click
        CS_Add("F_fish_morsel")
    End Sub

    Private Sub button_CS_cooked_fish_morsel_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_fish_morsel.Click
        CS_Add("F_cooked_fish_morsel")
    End Sub

    Private Sub button_CS_jellyfish_click(sender As Object, e As RoutedEventArgs) Handles button_CS_jellyfish.Click
        CS_Add("F_jellyfish")
    End Sub

    Private Sub button_CS_dead_jellyfish_click(sender As Object, e As RoutedEventArgs) Handles button_CS_dead_jellyfish.Click
        CS_Add("F_dead_jellyfish")
    End Sub

    Private Sub button_CS_cooked_jellyfish_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_jellyfish.Click
        CS_Add("F_cooked_jellyfish")
    End Sub

    Private Sub button_CS_dried_jellyfish_click(sender As Object, e As RoutedEventArgs) Handles button_CS_dried_jellyfish.Click
        CS_Add("F_dried_jellyfish")
    End Sub

    Private Sub button_CS_limpets_click(sender As Object, e As RoutedEventArgs) Handles button_CS_limpets.Click
        CS_Add("F_limpets")
    End Sub

    Private Sub button_CS_cooked_limpets_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_limpets.Click
        CS_Add("F_cooked_limpets")
    End Sub

    Private Sub button_CS_mussel_click(sender As Object, e As RoutedEventArgs) Handles button_CS_mussel.Click
        CS_Add("F_mussel")
    End Sub

    Private Sub button_CS_cooked_mussel_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_mussel.Click
        CS_Add("F_cooked_mussel")
    End Sub

    Private Sub button_CS_dead_dogfish_click(sender As Object, e As RoutedEventArgs) Handles button_CS_dead_dogfish.Click
        CS_Add("F_dead_dogfish")
    End Sub

    Private Sub button_CS_wobster_click(sender As Object, e As RoutedEventArgs) Handles button_CS_wobster.Click
        CS_Add("F_wobster")
    End Sub

    Private Sub button_CS_raw_fish_click(sender As Object, e As RoutedEventArgs) Handles button_CS_raw_fish.Click
        CS_Add("F_raw_fish")
    End Sub

    Private Sub button_CS_fish_steak_click(sender As Object, e As RoutedEventArgs) Handles button_CS_fish_steak.Click
        CS_Add("F_fish_steak")
    End Sub

    Private Sub button_CS_shark_fin_click(sender As Object, e As RoutedEventArgs) Handles button_CS_shark_fin.Click
        CS_Add("F_shark_fin")
    End Sub

    REM ------------------食材(蔬菜)-------------------
    Private Sub button_CS_blue_cap_click(sender As Object, e As RoutedEventArgs) Handles button_CS_blue_cap.Click
        CS_Add("F_blue_cap")
    End Sub

    Private Sub button_CS_cooked_blue_cap_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_blue_cap.Click
        CS_Add("F_cooked_blue_cap")
    End Sub

    Private Sub button_CS_green_cap_click(sender As Object, e As RoutedEventArgs) Handles button_CS_green_cap.Click
        CS_Add("F_green_cap")
    End Sub

    Private Sub button_CS_cooked_green_cap_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_green_cap.Click
        CS_Add("F_cooked_green_cap")
    End Sub

    Private Sub button_CS_red_cap_click(sender As Object, e As RoutedEventArgs) Handles button_CS_red_cap.Click
        CS_Add("F_red_cap")
    End Sub

    Private Sub button_CS_cooked_red_cap_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_red_cap.Click
        CS_Add("F_cooked_red_cap")
    End Sub

    Private Sub button_CS_eggplant_click(sender As Object, e As RoutedEventArgs) Handles button_CS_eggplant.Click
        CS_Add("F_eggplant")
    End Sub

    Private Sub button_CS_braised_eggplant_click(sender As Object, e As RoutedEventArgs) Handles button_CS_braised_eggplant.Click
        CS_Add("F_braised_eggplant")
    End Sub

    Private Sub button_CS_carrot_click(sender As Object, e As RoutedEventArgs) Handles button_CS_carrot.Click
        CS_Add("F_carrot")
    End Sub

    Private Sub button_CS_roasted_carrot_click(sender As Object, e As RoutedEventArgs) Handles button_CS_roasted_carrot.Click
        CS_Add("F_roasted_carrot")
    End Sub

    Private Sub button_CS_corn_click(sender As Object, e As RoutedEventArgs) Handles button_CS_corn.Click
        CS_Add("F_corn")
    End Sub

    Private Sub button_CS_popcorn_click(sender As Object, e As RoutedEventArgs) Handles button_CS_popcorn.Click
        CS_Add("F_popcorn")
    End Sub

    Private Sub button_CS_pumpkin_click(sender As Object, e As RoutedEventArgs) Handles button_CS_pumpkin.Click
        CS_Add("F_pumpkin")
    End Sub

    Private Sub button_CS_hot_pumpkin_click(sender As Object, e As RoutedEventArgs) Handles button_CS_hot_pumpkin.Click
        CS_Add("F_hot_pumpkin")
    End Sub

    Private Sub button_CS_cactus_flesh_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cactus_flesh.Click
        CS_Add("F_cactus_flesh")
    End Sub

    Private Sub button_CS_cooked_cactus_flesh_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_cactus_flesh.Click
        CS_Add("F_cooked_cactus_flesh")
    End Sub

    Private Sub button_CS_cactus_flower_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cactus_flower.Click
        CS_Add("F_cactus_flower")
    End Sub

    Private Sub button_CS_sweet_potato_click(sender As Object, e As RoutedEventArgs) Handles button_CS_sweet_potato.Click
        CS_Add("F_sweet_potato")
    End Sub

    Private Sub button_CS_cooked_sweet_potato_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_sweet_potato.Click
        CS_Add("F_cooked_sweet_potato")
    End Sub

    Private Sub button_CS_seaweed_click(sender As Object, e As RoutedEventArgs) Handles button_CS_seaweed.Click
        CS_Add("F_seaweed")
    End Sub

    Private Sub button_CS_roasted_seaweed_click(sender As Object, e As RoutedEventArgs) Handles button_CS_roasted_seaweed.Click
        CS_Add("F_roasted_seaweed")
    End Sub

    Private Sub button_CS_dried_seaweed_click(sender As Object, e As RoutedEventArgs) Handles button_CS_dried_seaweed.Click
        CS_Add("F_dried_seaweed")
    End Sub

    REM ------------------食材(水果)-------------------
    Private Sub button_CS_banana_click(sender As Object, e As RoutedEventArgs) Handles button_CS_banana.Click
        CS_Add("F_banana")
    End Sub

    Private Sub button_CS_cooked_banana_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_banana.Click
        CS_Add("F_cooked_banana")
    End Sub

    Private Sub button_CS_juicy_berries_click(sender As Object, e As RoutedEventArgs) Handles button_CS_juicy_berries.Click
        CS_Add("F_juicy_berries")
    End Sub

    Private Sub button_CS_roasted_juicy_berries_click(sender As Object, e As RoutedEventArgs) Handles button_CS_roasted_juicy_berries.Click
        CS_Add("F_roasted_juicy_berries")
    End Sub

    Private Sub button_CS_berries_click(sender As Object, e As RoutedEventArgs) Handles button_CS_berries.Click
        CS_Add("F_berries")
    End Sub

    Private Sub button_CS_roasted_berrie_click(sender As Object, e As RoutedEventArgs) Handles button_CS_roasted_berrie.Click
        CS_Add("F_roasted_berrie")
    End Sub

    Private Sub button_CS_dragon_fruit_click(sender As Object, e As RoutedEventArgs) Handles button_CS_dragon_fruit.Click
        CS_Add("F_dragon_fruit")
    End Sub

    Private Sub button_CS_prepared_dragon_fruit_click(sender As Object, e As RoutedEventArgs) Handles button_CS_prepared_dragon_fruit.Click
        CS_Add("F_prepared_dragon_fruit")
    End Sub

    Private Sub button_CS_durian_click(sender As Object, e As RoutedEventArgs) Handles button_CS_durian.Click
        CS_Add("F_durian")
    End Sub

    Private Sub button_CS_extra_smelly_durian_click(sender As Object, e As RoutedEventArgs) Handles button_CS_extra_smelly_durian.Click
        CS_Add("F_extra_smelly_durian")
    End Sub

    Private Sub button_CS_pomegranate_click(sender As Object, e As RoutedEventArgs) Handles button_CS_pomegranate.Click
        CS_Add("F_pomegranate")
    End Sub

    Private Sub button_CS_sliced_pomegranate_click(sender As Object, e As RoutedEventArgs) Handles button_CS_sliced_pomegranate.Click
        CS_Add("F_sliced_pomegranate")
    End Sub

    Private Sub button_CS_watermelon_click(sender As Object, e As RoutedEventArgs) Handles button_CS_watermelon.Click
        CS_Add("F_watermelon")
    End Sub

    Private Sub button_CS_grilled_watermelon_click(sender As Object, e As RoutedEventArgs) Handles button_CS_grilled_watermelon.Click
        CS_Add("F_grilled_watermelon")
    End Sub

    Private Sub button_CS_halved_coconut_click(sender As Object, e As RoutedEventArgs) Handles button_CS_halved_coconut.Click
        CS_Add("F_halved_coconut")
    End Sub

    Private Sub button_CS_roasted_coconut_click(sender As Object, e As RoutedEventArgs) Handles button_CS_roasted_coconut.Click
        CS_Add("F_roasted_coconut")
    End Sub

    REM ------------------食材(蛋类)-------------------
    Private Sub button_CS_egg_click(sender As Object, e As RoutedEventArgs) Handles button_CS_egg.Click
        CS_Add("F_egg")
    End Sub

    Private Sub button_CS_cooked_egg_click(sender As Object, e As RoutedEventArgs) Handles button_CS_cooked_egg.Click
        CS_Add("F_cooked_egg")
    End Sub

    Private Sub button_CS_tallbird_egg_click(sender As Object, e As RoutedEventArgs) Handles button_CS_tallbird_egg.Click
        CS_Add("F_tallbird_egg")
    End Sub

    Private Sub button_CS_fried_tallbird_egg_click(sender As Object, e As RoutedEventArgs) Handles button_CS_fried_tallbird_egg.Click
        CS_Add("F_fried_tallbird_egg")
    End Sub

    Private Sub button_CS_doydoy_egg_click(sender As Object, e As RoutedEventArgs) Handles button_CS_doydoy_egg.Click
        CS_Add("F_doydoy_egg")
    End Sub

    Private Sub button_CS_fried_doydoy_egg_click(sender As Object, e As RoutedEventArgs) Handles button_CS_fried_doydoy_egg.Click
        CS_Add("F_fried_doydoy_egg")
    End Sub

    REM ------------------食材(其他)-------------------
    Private Sub button_CS_butterfly_wing_click(sender As Object, e As RoutedEventArgs) Handles button_CS_butterfly_wing.Click
        CS_Add("F_butterfly_wing")
    End Sub

    Private Sub button_CS_butter_click(sender As Object, e As RoutedEventArgs) Handles button_CS_butter.Click
        CS_Add("F_butter")
    End Sub

    Private Sub button_CS_honey_click(sender As Object, e As RoutedEventArgs) Handles button_CS_honey.Click
        CS_Add("F_honey")
    End Sub

    Private Sub button_CS_honeycomb_click(sender As Object, e As RoutedEventArgs) Handles button_CS_honeycomb.Click
        CS_Add("F_honeycomb")
    End Sub

    Private Sub button_CS_lichen_click(sender As Object, e As RoutedEventArgs) Handles button_CS_lichen.Click
        CS_Add("F_lichen")
    End Sub

    Private Sub button_CS_mandrake_click(sender As Object, e As RoutedEventArgs) Handles button_CS_mandrake.Click
        CS_Add("F_mandrake")
    End Sub

    Private Sub button_CS_electric_milk_click(sender As Object, e As RoutedEventArgs) Handles button_CS_electric_milk.Click
        CS_Add("F_electric_milk")
    End Sub

    Private Sub button_CS_ice_click(sender As Object, e As RoutedEventArgs) Handles button_CS_ice.Click
        CS_Add("F_ice")
    End Sub

    Private Sub button_CS_roasted_birchnut_click(sender As Object, e As RoutedEventArgs) Handles button_CS_roasted_birchnut.Click
        CS_Add("F_roasted_birchnut")
    End Sub

    Private Sub button_CS_twigs_click(sender As Object, e As RoutedEventArgs) Handles button_CS_twigs.Click
        CS_Add("G_twigs")
    End Sub

    Private Sub button_CS_butterfly_wing_sw_click(sender As Object, e As RoutedEventArgs) Handles button_CS_butterfly_wing_sw.Click
        CS_Add("F_butterfly_wing_sw")
    End Sub

    Private Sub button_CS_coffee_beans_click(sender As Object, e As RoutedEventArgs) Handles button_CS_coffee_beans.Click
        CS_Add("F_coffee_beans")
    End Sub

    Private Sub button_CS_roasted_coffee_beans_click(sender As Object, e As RoutedEventArgs) Handles button_CS_roasted_coffee_beans.Click
        CS_Add("F_roasted_coffee_beans")
    End Sub

    REM 是否启用便携式烹饪锅
    Private Sub checkBox_CS_PortableCrockPot_click() Handles checkBox_CS_PortableCrockPot.Click
        If checkBox_CS_PortableCrockPot.IsChecked = True Then
            Reg_Write("CS_PortableCrockPot", 0)
            checkBox_CS_CrockPot.IsChecked = False
            CS_image_CrockPot.Source = Picture_Short_Name(Res_Short_Name("CP_PortableCrockPot"))
            CS_PortableCrockPot = True
        Else
            Reg_Write("CS_PortableCrockPot", 1)
            checkBox_CS_CrockPot.IsChecked = True
            CS_image_CrockPot.Source = Picture_Short_Name(Res_Short_Name("CP_CrockPot"))
            CS_PortableCrockPot = False
        End If
    End Sub

    Private Sub checkBox_CS_CrockPot_click() Handles checkBox_CS_CrockPot.Click
        If checkBox_CS_CrockPot.IsChecked = True Then
            Reg_Write("CS_PortableCrockPot", 1)
            checkBox_CS_PortableCrockPot.IsChecked = False
            CS_image_CrockPot.Source = Picture_Short_Name(Res_Short_Name("CP_CrockPot"))
            CS_PortableCrockPot = False
        Else
            Reg_Write("CS_PortableCrockPot", 0)
            checkBox_CS_PortableCrockPot.IsChecked = True
            CS_image_CrockPot.Source = Picture_Short_Name(Res_Short_Name("CP_PortableCrockPot"))
            CS_PortableCrockPot = True
        End If
    End Sub

    REM 添加食材
    Private Sub CS_Add(Name As String)
        If CS_Recipe_1 = "" Then
            CS_Recipe_1 = Name
            CS_image_Food_1.Source = Picture_Short_Name(Res_Short_Name(Name))
        ElseIf CS_Recipe_2 = "" Then
            CS_Recipe_2 = Name
            CS_image_Food_2.Source = Picture_Short_Name(Res_Short_Name(Name))
        ElseIf CS_Recipe_3 = "" Then
            CS_Recipe_3 = Name
            CS_image_Food_3.Source = Picture_Short_Name(Res_Short_Name(Name))
        ElseIf CS_Recipe_4 = "" Then
            CS_Recipe_4 = Name
            CS_image_Food_4.Source = Picture_Short_Name(Res_Short_Name(Name))
            'Else
            '    MsgBox("食材已满，不可添加！")
        End If
        If CS_Recipe_1 <> "" And CS_Recipe_2 <> "" And CS_Recipe_3 <> "" And CS_Recipe_4 <> "" And checkBox_CS_AutoCalculation.IsChecked = True Then
            CS_CrockPotCalculation()
        End If
    End Sub

    REM 删除食材
    Private Sub button_CS_Food_1_click(sender As Object, e As RoutedEventArgs) Handles button_CS_Food_1.Click
        CS_Recipe_1 = ""
        CS_image_Food_1.Source = Picture_Short_Name()
    End Sub

    Private Sub button_CS_Food_2_click(sender As Object, e As RoutedEventArgs) Handles button_CS_Food_2.Click
        CS_Recipe_2 = ""
        CS_image_Food_2.Source = Picture_Short_Name()
    End Sub

    Private Sub button_CS_Food_3_click(sender As Object, e As RoutedEventArgs) Handles button_CS_Food_3.Click
        CS_Recipe_3 = ""
        CS_image_Food_3.Source = Picture_Short_Name()
    End Sub

    Private Sub button_CS_Food_4_click(sender As Object, e As RoutedEventArgs) Handles button_CS_Food_4.Click
        CS_Recipe_4 = ""
        CS_image_Food_4.Source = Picture_Short_Name()
    End Sub

    REM 食材属性统计
    Private Sub CS_RecipeStatistics(Name As String)
        Select Case Name
            Case "F_eel"
                CS_FT_Fishes += 1
                CS_FT_Eel += 1
                CS_FT_Meats += 0.5
            Case "F_cooked_eel"
                CS_FT_Fishes += 1
                CS_FT_Eel += 1
                CS_FT_Meats += 0.5
            Case "F_fish"
                CS_FT_Fishes += 1
                CS_FT_Meats += 0.5
            Case "F_cooked_fish"
                CS_FT_Fishes += 1
                CS_FT_Meats += 0.5
            Case "F_frog_legs"
                CS_FT_Meats += 0.5
                CS_FT_FrogLegs += 1
            Case "F_cooked_frog_legs"
                CS_FT_Meats += 0.5
                CS_FT_FrogLegs += 1
            Case "F_meat"
                CS_FT_Meats += 1
            Case "F_cooked_meat"
                CS_FT_Meats += 1
            Case "F_jerky"
                CS_FT_Meats += 1
            Case "F_monster_meat"
                CS_FT_Meats += 1
                CS_FT_MonsterFoods += 1
            Case "F_cooked_monster_meat"
                CS_FT_Meats += 1
                CS_FT_MonsterFoods += 1
            Case "F_monster_jerky"
                CS_FT_Meats += 1
                CS_FT_MonsterFoods += 1
            Case "F_morsel"
                CS_FT_Meats += 0.5
            Case "F_cooked_morsel"
                CS_FT_Meats += 0.5
            Case "F_small_jerky"
                CS_FT_Meats += 0.5
            Case "F_drumstick"
                CS_FT_Meats += 0.5
                CS_FT_Drumstick += 1
            Case "F_fried_drumstick"
                CS_FT_Meats += 0.5
                CS_FT_Drumstick += 1
            Case "F_moleworm"
                CS_FT_Moleworm += 1
            Case "F_tropical_fish"
                CS_FT_Meats += 0.5
                CS_FT_Fishes += 1
            Case "F_fish_morsel"
                CS_FT_Fishes += 0.5
            Case "F_cooked_fish_morsel"
                CS_FT_Fishes += 0.5
            Case "F_jellyfish"
                CS_FT_Fishes += 1
                CS_FT_MonsterFoods += 1
                CS_FT_Jellyfish += 1
            Case "F_dead_jellyfish"
                CS_FT_Fishes += 1
                CS_FT_MonsterFoods += 1
            Case "F_cooked_jellyfish"
                CS_FT_Fishes += 1
                CS_FT_MonsterFoods += 1
            Case "F_dried_jellyfish"
                CS_FT_Fishes += 1
                CS_FT_MonsterFoods += 1
            Case "F_limpets"
                CS_FT_Fishes += 0.5
                CS_FT_Limpets += 1
            Case "F_cooked_limpets"
                CS_FT_Fishes += 0.5
            Case "F_mussel"
                CS_FT_Fishes += 0.5
                CS_FT_Mussel += 1
            Case "F_cooked_mussel"
                CS_FT_Fishes += 0.5
                CS_FT_Mussel += 1
            Case "F_dead_dogfish"
                CS_FT_Fishes += 1
                CS_FT_Meats += 0.5
            Case "F_dead_swordfish"
                CS_FT_Fishes += 1
                CS_FT_Meats += 0.5
            Case "F_wobster"
                CS_FT_Fishes += 2
                CS_FT_Wobster += 1
            Case "F_raw_fish"
                CS_FT_Fishes += 1
                CS_FT_Meats += 0.5
            Case "F_fish_steak"
                CS_FT_Fishes += 1
                CS_FT_Meats += 0.5
            Case "F_shark_fin"
                CS_FT_Fishes += 1
                CS_FT_Meats += 0.5
                CS_FT_SharkFin += 1
            Case "F_blue_cap"
                CS_FT_Vegetables += 0.5
            Case "F_cooked_blue_cap"
                CS_FT_Vegetables += 0.5
            Case "F_green_cap"
                CS_FT_Vegetables += 0.5
            Case "F_cooked_green_cap"
                CS_FT_Vegetables += 0.5
            Case "F_red_cap"
                CS_FT_Vegetables += 0.5
            Case "F_cooked_red_cap"
                CS_FT_Vegetables += 0.5
            Case "F_eggplant"
                CS_FT_Vegetables += 1
                CS_FT_Eggplant += 1
            Case "F_braised_eggplant"
                CS_FT_Vegetables += 1
                CS_FT_Eggplant += 1
            Case "F_carrot"
                CS_FT_Vegetables += 1
            Case "F_roasted_carrot"
                CS_FT_Vegetables += 1
            Case "F_corn"
                CS_FT_Vegetables += 1
                CS_FT_Corn += 1
            Case "F_popcorn"
                CS_FT_Vegetables += 1
                CS_FT_Corn += 1
            Case "F_pumpkin"
                CS_FT_Vegetables += 1
                CS_FT_Pumpkin += 1
            Case "F_hot_pumpkin"
                CS_FT_Vegetables += 1
                CS_FT_Pumpkin += 1
            Case "F_cactus_flesh"
                CS_FT_Vegetables += 1
                CS_FT_CactusFlesh += 1
            Case "F_cooked_cactus_flesh"
                CS_FT_Vegetables += 1
            Case "F_cactus_flower"
                CS_FT_Vegetables += 1
                CS_FT_CactusFlower += 1
            Case "F_sweet_potato"
                CS_FT_Vegetables += 1
                CS_FT_SweetPotato += 1
            Case "F_cooked_sweet_potato"
                CS_FT_Vegetables += 1
            Case "F_seaweed"
                CS_FT_Vegetables += 0.5
                CS_FT_Seaweed += 1
            Case "F_roasted_seaweed"
                CS_FT_Vegetables += 0.5
            Case "F_dried_seaweed"
                CS_FT_Vegetables += 0.5
            Case "F_banana"
                CS_FT_Fruit += 1
                CS_FT_Banana += 1
            Case "F_cooked_banana"
                CS_FT_Fruit += 1
            Case "F_juicy_berries"
                CS_FT_Fruit += 0.5
            Case "F_roasted_juicy_berries"
                CS_FT_Fruit += 0.5
            Case "F_berries"
                CS_FT_Fruit += 0.5
                CS_FT_Berries += 1
            Case "F_roasted_berrie"
                CS_FT_Fruit += 0.5
                CS_FT_Berries += 1
            Case "F_dragon_fruit"
                CS_FT_Fruit += 1
                CS_FT_DragonFruit += 1
            Case "F_prepared_dragon_fruit"
                CS_FT_Fruit += 1
                CS_FT_DragonFruit += 1
            Case "F_durian"
                CS_FT_Fruit += 1
                CS_FT_MonsterFoods += 1
            Case "F_extra_smelly_durian"
                CS_FT_Fruit += 1
                CS_FT_MonsterFoods += 1
            Case "F_pomegranate"
                CS_FT_Fruit += 1
            Case "F_sliced_pomegranate"
                CS_FT_Fruit += 1
            Case "F_watermelon"
                CS_FT_Fruit += 1
                CS_FT_Watermelon += 1
            Case "F_grilled_watermelon"
                CS_FT_Fruit += 1
            Case "F_halved_coconut"
                CS_FT_Fruit += 1
            Case "F_roasted_coconut"
                CS_FT_Fruit += 1
            Case "F_egg"
                CS_FT_Eggs += 1
            Case "F_cooked_egg"
                CS_FT_Eggs += 1
            Case "F_tallbird_egg"
                CS_FT_Eggs += 4
            Case "F_fried_tallbird_egg"
                CS_FT_Eggs += 4
            Case "F_doydoy_egg"
                CS_FT_Eggs += 1
            Case "F_fried_doydoy_egg"
                CS_FT_Eggs += 1
            Case "F_butterfly_wing"
                CS_FT_Butterfly_wings += 1
            Case "F_butter"
                CS_FT_DairyProduct += 1
                CS_FT_Butter += 1
            Case "F_honey"
                CS_FT_Sweetener += 1
                CS_FT_Honey += 1
            Case "F_honeycomb"
                CS_FT_Sweetener += 1
            Case "F_lichen"
                CS_FT_Vegetables += 1
                CS_FT_Lichen += 1
            Case "F_mandrake"
                CS_FT_Vegetables += 1
                CS_FT_Mandrake += 1
            Case "F_electric_milk"
                CS_FT_DairyProduct += 1
            Case "F_ice"
                CS_FT_Ice += 1
            Case "F_roasted_birchnut"
                CS_FT_RoastedBirchnut += 1
            Case "G_twigs"
                CS_FT_Twigs += 1
            Case "F_butterfly_wing_sw"
                CS_FT_Butterfly_wings += 1
            Case "F_coffee_beans"
                CS_FT_Fruit += 0.5
            Case "F_roasted_coffee_beans"
                CS_FT_Fruit += 1
                CS_FT_RoastedCoffeeBeans += 1
        End Select
    End Sub

    Private Sub checkBox_CS_AutoCalculation_click(sender As Object, e As RoutedEventArgs) Handles checkBox_CS_AutoCalculation.Click
        If checkBox_CS_AutoCalculation.IsChecked = True Then
            Reg_Write("CS_AutoCalculation", 1)
        Else
            Reg_Write("CS_AutoCalculation", 0)
        End If
    End Sub

    Private Sub checkBox_CS_AutoClean_click(sender As Object, e As RoutedEventArgs) Handles checkBox_CS_AutoClean.Click
        If checkBox_CS_AutoClean.IsChecked = True Then
            Reg_Write("CS_AutoClean", 1)
        Else
            Reg_Write("CS_AutoClean", 0)
        End If
    End Sub

    REM 烹饪
    Private Sub button_CS_CrockPot_click(sender As Object, e As RoutedEventArgs) Handles button_CS_CrockPot.Click
        CS_CrockPotCalculation()
    End Sub

    Private Sub button_CS_Switch_Left_click(sender As Object, e As RoutedEventArgs) Handles button_CS_Switch_Left.Click
        button_CS_Switch_Right.IsEnabled = True
        If FoodIndex <> 0 Then
            FoodIndex -= 1
            If FoodIndex = 0 Then
                button_CS_Switch_Left.IsEnabled = False
            End If
            CS_F_name = CrockPotList(FoodIndex)
            Select Case CrockPotList(FoodIndex)
                Case "新鲜水果薄饼"
                    CS_image_Food_5_Source("F_fresh_fruit_crepes")
                Case "怪物鞑靼"
                    CS_image_Food_5_Source("F_monster_tartare")
                Case "贝类淡菜汤"
                    CS_image_Food_5_Source("F_mussel_bouillabaise")
                Case "薯蛋奶酥"
                    CS_image_Food_5_Source("F_sweet_potato_souffle")
                Case "龙虾浓汤"
                    CS_image_Food_5_Source("F_lobster_bisque")
                Case "汤"
                    CS_image_Food_5_Source("F_bisque")
                Case "咖啡"
                    CS_image_Food_5_Source("F_coffee")
                Case "海鲜牛排"
                    CS_image_Food_5_Source("F_surf_'n'_turf")
                Case "龙虾正餐"
                    CS_image_Food_5_Source("F_lobster_dinner")
                Case "香蕉冰淇淋"
                    CS_image_Food_5_Source("F_banana_pop")
                Case "加州卷"
                    CS_image_Food_5_Source("F_california_roll")
                Case "果冻冰淇淋"
                    CS_image_Food_5_Source("F_jelly-O_pop")
                Case "橘汁腌鱼"
                    CS_image_Food_5_Source("F_ceviche")
                Case "鱼翅汤"
                    CS_image_Food_5_Source("F_shark_fin_soup")
                Case "海鲜汤"
                    CS_image_Food_5_Source("F_seafood_gumbo")
                Case "鼹鼠鳄梨酱"
                    CS_image_Food_5_Source("F_guacamole")
                Case "花瓣沙拉"
                    CS_image_Food_5_Source("F_flower_salad")
                Case "冰淇淋"
                    CS_image_Food_5_Source("F_ice_cream")
                Case "西瓜冰"
                    CS_image_Food_5_Source("F_melonsicle")
                Case "水果杂烩"
                    CS_image_Food_5_Source("F_trail_mix")
                Case "辣椒酱"
                    CS_image_Food_5_Source("F_spicy_chili")
                Case "鳗鱼"
                    CS_image_Food_5_Source("F_unagi")
                Case "南瓜饼"
                    CS_image_Food_5_Source("F_pumpkin_cookie")
                Case "芝士蛋糕"
                    CS_image_Food_5_Source("F_powdercake")
                Case "曼德拉汤"
                    CS_image_Food_5_Source("F_mandrake_soup")
                Case "炸鱼条"
                    CS_image_Food_5_Source("F_fishsticks")
                Case "玉米饼包炸鱼"
                    CS_image_Food_5_Source("F_fish_tacos")
                Case "培根煎蛋"
                    CS_image_Food_5_Source("F_bacon_and_eggs")
                Case "火鸡正餐"
                    CS_image_Food_5_Source("F_turkey_dinner")
                Case "太妃糖"
                    CS_image_Food_5_Source("F_taffy")
                Case "华夫饼"
                    CS_image_Food_5_Source("F_waffles")
                Case "怪物千层饼"
                    CS_image_Food_5_Source("F_monster_lasagna")
                Case "饺子"
                    CS_image_Food_5_Source("F_pierogi")
                Case "肉串"
                    CS_image_Food_5_Source("F_kabobs")
                Case "蜜汁火腿"
                    CS_image_Food_5_Source("F_honey_ham")
                Case "甜蜜金砖"
                    CS_image_Food_5_Source("F_honey_nuggets")
                Case "奶油松饼"
                    CS_image_Food_5_Source("F_butter_muffin")
                Case "青蛙圆面包三明治"
                    CS_image_Food_5_Source("F_froggle_bunwich")
                Case "火龙果派"
                    CS_image_Food_5_Source("F_dragonpie")
                Case "香酥茄盒"
                    CS_image_Food_5_Source("F_stuffed_eggplant")
                Case "蔬菜杂烩"
                    CS_image_Food_5_Source("F_ratatouille")
                Case "果酱蜜饯"
                    CS_image_Food_5_Source("F_fist_full_of_jam")
                Case "水果拼盘"
                    CS_image_Food_5_Source("F_fruit_medley")
                Case "肉汤"
                    CS_image_Food_5_Source("F_meaty_stew")
                Case "肉丸"
                    CS_image_Food_5_Source("F_meatballs")
            End Select
            REM 显示食物名称
            TextBlock_CS_FoodName.Text = CS_F_name
            TextBlock_CS_FoodName.UpdateLayout()
            Dim CS_FoodName_MarginLeft As Integer
            CS_FoodName_MarginLeft = (Canvas_CookingSimulatorLeft.ActualWidth - TextBlock_CS_FoodName.ActualWidth) / 2
            Dim CS_FoodName_T As New Thickness()
            CS_FoodName_T.Top = 555
            CS_FoodName_T.Left = CS_FoodName_MarginLeft
            TextBlock_CS_FoodName.Margin = CS_FoodName_T
        End If
    End Sub

    Private Sub button_CS_Switch_Right_click(sender As Object, e As RoutedEventArgs) Handles button_CS_Switch_Right.Click
        button_CS_Switch_Left.IsEnabled = True
        If FoodIndex <> CrockPotListIndex Then
            FoodIndex += 1
            If FoodIndex = CrockPotListIndex Then
                button_CS_Switch_Right.IsEnabled = False
            End If
            CS_F_name = CrockPotList(FoodIndex)
            Select Case CrockPotList(FoodIndex)
                Case "新鲜水果薄饼"
                    CS_image_Food_5_Source("F_fresh_fruit_crepes")
                Case "怪物鞑靼"
                    CS_image_Food_5_Source("F_monster_tartare")
                Case "贝类淡菜汤"
                    CS_image_Food_5_Source("F_mussel_bouillabaise")
                Case "薯蛋奶酥"
                    CS_image_Food_5_Source("F_sweet_potato_souffle")
                Case "龙虾浓汤"
                    CS_image_Food_5_Source("F_lobster_bisque")
                Case "汤"
                    CS_image_Food_5_Source("F_bisque")
                Case "咖啡"
                    CS_image_Food_5_Source("F_coffee")
                Case "海鲜牛排"
                    CS_image_Food_5_Source("F_surf_'n'_turf")
                Case "龙虾正餐"
                    CS_image_Food_5_Source("F_lobster_dinner")
                Case "香蕉冰淇淋"
                    CS_image_Food_5_Source("F_banana_pop")
                Case "加州卷"
                    CS_image_Food_5_Source("F_california_roll")
                Case "果冻冰淇淋"
                    CS_image_Food_5_Source("F_jelly-O_pop")
                Case "橘汁腌鱼"
                    CS_image_Food_5_Source("F_ceviche")
                Case "鱼翅汤"
                    CS_image_Food_5_Source("F_shark_fin_soup")
                Case "海鲜汤"
                    CS_image_Food_5_Source("F_seafood_gumbo")
                Case "鼹鼠鳄梨酱"
                    CS_image_Food_5_Source("F_guacamole")
                Case "花瓣沙拉"
                    CS_image_Food_5_Source("F_flower_salad")
                Case "冰淇淋"
                    CS_image_Food_5_Source("F_ice_cream")
                Case "西瓜冰"
                    CS_image_Food_5_Source("F_melonsicle")
                Case "水果杂烩"
                    CS_image_Food_5_Source("F_trail_mix")
                Case "辣椒酱"
                    CS_image_Food_5_Source("F_spicy_chili")
                Case "鳗鱼"
                    CS_image_Food_5_Source("F_unagi")
                Case "南瓜饼"
                    CS_image_Food_5_Source("F_pumpkin_cookie")
                Case "芝士蛋糕"
                    CS_image_Food_5_Source("F_powdercake")
                Case "曼德拉汤"
                    CS_image_Food_5_Source("F_mandrake_soup")
                Case "炸鱼条"
                    CS_image_Food_5_Source("F_fishsticks")
                Case "玉米饼包炸鱼"
                    CS_image_Food_5_Source("F_fish_tacos")
                Case "培根煎蛋"
                    CS_image_Food_5_Source("F_bacon_and_eggs")
                Case "火鸡正餐"
                    CS_image_Food_5_Source("F_turkey_dinner")
                Case "太妃糖"
                    CS_image_Food_5_Source("F_taffy")
                Case "华夫饼"
                    CS_image_Food_5_Source("F_waffles")
                Case "怪物千层饼"
                    CS_image_Food_5_Source("F_monster_lasagna")
                Case "饺子"
                    CS_image_Food_5_Source("F_pierogi")
                Case "肉串"
                    CS_image_Food_5_Source("F_kabobs")
                Case "蜜汁火腿"
                    CS_image_Food_5_Source("F_honey_ham")
                Case "甜蜜金砖"
                    CS_image_Food_5_Source("F_honey_nuggets")
                Case "奶油松饼"
                    CS_image_Food_5_Source("F_butter_muffin")
                Case "青蛙圆面包三明治"
                    CS_image_Food_5_Source("F_froggle_bunwich")
                Case "火龙果派"
                    CS_image_Food_5_Source("F_dragonpie")
                Case "香酥茄盒"
                    CS_image_Food_5_Source("F_stuffed_eggplant")
                Case "蔬菜杂烩"
                    CS_image_Food_5_Source("F_ratatouille")
                Case "果酱蜜饯"
                    CS_image_Food_5_Source("F_fist_full_of_jam")
                Case "水果拼盘"
                    CS_image_Food_5_Source("F_fruit_medley")
                Case "肉汤"
                    CS_image_Food_5_Source("F_meaty_stew")
                Case "肉丸"
                    CS_image_Food_5_Source("F_meatballs")
            End Select
            REM 显示食物名称
            TextBlock_CS_FoodName.Text = CS_F_name
            TextBlock_CS_FoodName.UpdateLayout()
            Dim CS_FoodName_MarginLeft As Integer
            CS_FoodName_MarginLeft = (Canvas_CookingSimulatorLeft.ActualWidth - TextBlock_CS_FoodName.ActualWidth) / 2
            Dim CS_FoodName_T As New Thickness()
            CS_FoodName_T.Top = 555
            CS_FoodName_T.Left = CS_FoodName_MarginLeft
            TextBlock_CS_FoodName.Margin = CS_FoodName_T
        End If
    End Sub

    REM 向食物列表添加食物
    Private Sub CS_CrockPotListAddFood(FoodName As String, FoodPriority As SByte)
        If FoodPriority >= CrockPotMaxPriority Then
            CrockPotMaxPriority = FoodPriority
            CrockPotListIndex += 1
            ReDim Preserve CrockPotList(CrockPotListIndex)
            CrockPotList(CrockPotListIndex) = FoodName
        End If
    End Sub

    REM 烹饪结果图片
    Private Sub CS_image_Food_5_Source(source As String)
        CS_image_Food_5.Source = Picture_Short_Name(Res_Short_Name(source))
    End Sub

    Private Sub CS_CrockPotCalculation()
        REM 判断食材是否足够
        If CS_Recipe_1 = "" Or CS_Recipe_2 = "" Or CS_Recipe_3 = "" Or CS_Recipe_4 = "" Then
            MsgBox("食材不足，请添加！")
            Exit Sub
        End If
        FoodIndex = 0
        REM 食物列表初始化
        Erase CrockPotList
        ReDim CrockPotList(0)
        CrockPotListIndex = -1
        CrockPotMaxPriority = -128
        REM 食材属性初始化
        CS_FT_Banana = 0
        CS_FT_Berries = 0
        CS_FT_Butter = 0
        CS_FT_Butterfly_wings = 0
        CS_FT_CactusFlesh = 0
        CS_FT_CactusFlower = 0
        CS_FT_Corn = 0
        CS_FT_DairyProduct = 0
        CS_FT_DragonFruit = 0
        CS_FT_Drumstick = 0
        CS_FT_Eel = 0
        CS_FT_Eggplant = 0
        CS_FT_Eggs = 0
        CS_FT_Fishes = 0
        CS_FT_FrogLegs = 0
        CS_FT_Fruit = 0
        CS_FT_Honey = 0
        CS_FT_Ice = 0
        CS_FT_Jellyfish = 0
        CS_FT_Lichen = 0
        CS_FT_Limpets = 0
        CS_FT_Mandrake = 0
        CS_FT_Meats = 0
        CS_FT_Moleworm = 0
        CS_FT_MonsterFoods = 0
        CS_FT_Mussel = 0
        CS_FT_Pumpkin = 0
        CS_FT_RoastedBirchnut = 0
        CS_FT_RoastedCoffeeBeans = 0
        CS_FT_Seaweed = 0
        CS_FT_SharkFin = 0
        CS_FT_Sweetener = 0
        CS_FT_SweetPotato = 0
        CS_FT_Twigs = 0
        CS_FT_Vegetables = 0
        CS_FT_Watermelon = 0
        CS_FT_Wobster = 0
        REM 属性统计
        CS_RecipeStatistics(CS_Recipe_1)
        CS_RecipeStatistics(CS_Recipe_2)
        CS_RecipeStatistics(CS_Recipe_3)
        CS_RecipeStatistics(CS_Recipe_4)
        REM 烹饪
        '------------------------SW------------------------
        If CS_ROG_SW_DST = 2 Or CS_ROG_SW_DST = 3 Or CS_ROG_SW_DST = 6 Or CS_ROG_SW_DST = 7 Then
            If CS_PortableCrockPot = True Then '便携式烹饪锅的四种食物
                If CS_FT_Fruit >= 2 And CS_FT_Butter >= 1 And CS_FT_Honey >= 1 Then
                    CS_CrockPotListAddFood("新鲜水果薄饼", 30)
                End If
                If CS_FT_MonsterFoods >= 2 And CS_FT_Eggs >= 1 And CS_FT_Vegetables >= 0.5 Then
                    CS_CrockPotListAddFood("怪物鞑靼", 30)
                End If
                If CS_FT_Mussel >= 2 And CS_FT_Vegetables >= 2 Then
                    CS_CrockPotListAddFood("贝类淡菜汤", 30)
                End If
                If CS_FT_SweetPotato >= 2 And CS_FT_Eggs >= 2 Then
                    CS_CrockPotListAddFood("薯蛋奶酥", 30)
                End If
            End If
            If CS_FT_Wobster >= 1 And CS_FT_Ice >= 1 Then
                CS_CrockPotListAddFood("龙虾浓汤", 30)
            End If
            If CS_FT_Limpets >= 3 And CS_FT_Ice >= 1 Then
                CS_CrockPotListAddFood("汤", 30)
            End If
            If CS_FT_RoastedCoffeeBeans >= 3 And (CS_FT_RoastedCoffeeBeans = 4 Or CS_FT_Sweetener = 1 Or CS_FT_DairyProduct = 1) Then
                CS_CrockPotListAddFood("咖啡", 30)
            End If
            If CS_FT_Meats >= 2.5 And CS_FT_Fishes >= 1.5 And CS_FT_Ice = 0 Then
                CS_CrockPotListAddFood("海鲜牛排", 30)
            End If
            If CS_FT_Wobster >= 1 And CS_FT_Butter >= 1 And CS_FT_Meats = 0 And CS_FT_Ice = 0 Then
                CS_CrockPotListAddFood("龙虾正餐", 25)
            End If
            If CS_FT_Banana >= 1 And CS_FT_Ice >= 1 And CS_FT_Twigs >= 1 And CS_FT_Meats = 0 And CS_FT_Fishes = 0 Then
                CS_CrockPotListAddFood("香蕉冰淇淋", 20)
            End If
            If CS_FT_Fishes >= 1 And CS_FT_Seaweed = 2 Then
                CS_CrockPotListAddFood("加州卷", 20)
            End If
            If CS_FT_Jellyfish >= 1 And CS_FT_Ice >= 1 And CS_FT_Twigs >= 1 Then
                CS_CrockPotListAddFood("果冻冰淇淋", 20)
            End If
            If CS_FT_Fishes >= 2 And CS_FT_Ice >= 1 Then
                CS_CrockPotListAddFood("橘汁腌鱼", 20)
            End If
            If CS_FT_SharkFin >= 1 Then
                CS_CrockPotListAddFood("鱼翅汤", 20)
            End If
            If CS_FT_Fishes >= 2.5 Then
                CS_CrockPotListAddFood("海鲜汤", 10)
            End If
        End If
        '------------------------其他------------------------
        If CS_FT_CactusFlesh >= 1 And CS_FT_Moleworm >= 1 And CS_FT_Fruit = 0 Then
            CS_CrockPotListAddFood("鼹鼠鳄梨酱", 10)
        End If
        If CS_FT_CactusFlower >= 1 And CS_FT_Vegetables >= 2 And CS_FT_Fruit = 0 And CS_FT_Meats = 0 And CS_FT_Eggs = 0 And CS_FT_Sweetener = 0 And CS_FT_Twigs = 0 Then
            CS_CrockPotListAddFood("花瓣沙拉", 10)
        End If
        If CS_FT_DairyProduct >= 1 And CS_FT_Ice >= 1 And CS_FT_Sweetener >= 1 And CS_FT_Meats = 0 And CS_FT_Eggs = 0 And CS_FT_Vegetables = 0 And CS_FT_Twigs = 0 Then
            CS_CrockPotListAddFood("冰淇淋", 10)
        End If
        If CS_FT_Watermelon >= 1 And CS_FT_Ice >= 1 And CS_FT_Twigs >= 1 And CS_FT_Meats = 0 And CS_FT_Eggs = 0 And CS_FT_Vegetables = 0 Then
            CS_CrockPotListAddFood("西瓜冰", 10)
        End If
        If CS_FT_RoastedBirchnut >= 1 And CS_FT_Berries >= 1 And CS_FT_Fruit >= 1 And CS_FT_Meats = 0 And CS_FT_Eggs = 0 And CS_FT_Vegetables = 0 And CS_FT_Sweetener = 0 Then
            CS_CrockPotListAddFood("水果杂烩", 10)
        End If
        If CS_FT_Vegetables >= 1.5 And CS_FT_Meats >= 1.5 Then
            CS_CrockPotListAddFood("辣椒酱", 10)
        End If
        If CS_FT_Eel >= 1 And CS_FT_Lichen >= 1 Then
            CS_CrockPotListAddFood("鳗鱼", 20)
        End If
        If CS_FT_Pumpkin >= 1 And CS_FT_Sweetener >= 2 Then
            CS_CrockPotListAddFood("南瓜饼", 10)
        End If
        If CS_FT_Corn >= 1 And CS_FT_Honey >= 1 And CS_FT_Twigs >= 1 Then
            CS_CrockPotListAddFood("芝士蛋糕", 10)
        End If
        If CS_FT_Mandrake >= 1 Then
            CS_CrockPotListAddFood("曼德拉汤", 10)
        End If
        If CS_FT_Fishes >= 0.5 And CS_FT_Twigs = 1 Then
            CS_CrockPotListAddFood("炸鱼条", 10)
        End If
        If CS_FT_Fishes >= 0.5 And CS_FT_Corn >= 1 Then
            CS_CrockPotListAddFood("玉米饼包炸鱼", 10)
        End If
        If CS_FT_Meats >= 1.5 And CS_FT_Eggs >= 2 And CS_FT_Vegetables = 0 Then
            CS_CrockPotListAddFood("培根煎蛋", 10)
        End If
        If CS_FT_Drumstick >= 2 And CS_FT_Meats >= 1.5 And (CS_FT_Vegetables >= 0.5 Or CS_FT_Fruit >= 0.5) Then
            CS_CrockPotListAddFood("火鸡正餐", 10)
        End If
        If CS_FT_Sweetener >= 3 And CS_FT_Meats = 0 Then
            CS_CrockPotListAddFood("太妃糖", 10)
        End If
        If CS_FT_Butter >= 1 And CS_FT_Eggs >= 1 And CS_FT_Berries >= 1 Then
            CS_CrockPotListAddFood("华夫饼", 10)
        End If
        If CS_FT_MonsterFoods >= 2 And CS_FT_Twigs = 0 Then
            CS_CrockPotListAddFood("怪物千层饼", 10)
        End If
        If CS_FT_Eggs >= 1 And CS_FT_Meats >= 0.5 And CS_FT_Vegetables >= 0.5 And CS_FT_Twigs = 0 Then
            CS_CrockPotListAddFood("饺子", 5)
        End If
        If CS_FT_Meats >= 0.5 And CS_FT_Twigs = 1 And CS_FT_MonsterFoods <= 1 Then
            CS_CrockPotListAddFood("肉串", 5)
        End If
        If CS_FT_Meats >= 2 And CS_FT_Honey >= 1 And CS_FT_Twigs = 0 Then
            CS_CrockPotListAddFood("蜜汁火腿", 2)
        End If
        If CS_FT_Meats >= 0.5 And CS_FT_Meats < 2 And CS_FT_Honey >= 1 And CS_FT_Twigs = 0 Then
            CS_CrockPotListAddFood("甜蜜金砖", 2)
        End If
        If CS_FT_Butterfly_wings >= 1 And CS_FT_Vegetables >= 0.5 And CS_FT_Meats = 0 Then
            CS_CrockPotListAddFood("奶油松饼", 1)
        End If
        If CS_FT_FrogLegs >= 1 And CS_FT_Vegetables >= 0.5 Then
            CS_CrockPotListAddFood("青蛙圆面包三明治", 1)
        End If
        If CS_FT_DragonFruit >= 1 And CS_FT_Meats = 0 Then
            CS_CrockPotListAddFood("火龙果派", 1)
        End If
        If CS_FT_Eggplant >= 1 And CS_FT_Vegetables >= 0.5 Then
            CS_CrockPotListAddFood("香酥茄盒", 1)
        End If
        If CS_FT_Vegetables >= 0.5 And CS_FT_Meats = 0 And CS_FT_Twigs = 0 Then
            CS_CrockPotListAddFood("蔬菜杂烩", 0)
        End If
        If CS_FT_Fruit >= 0.5 And CS_FT_Meats = 0 And CS_FT_Vegetables = 0 Then
            If CS_FT_Fruit < 3 Then
                CS_CrockPotListAddFood("果酱蜜饯", 0)
            Else
                If CS_FT_Twigs = 0 Then
                    CS_CrockPotListAddFood("果酱蜜饯", 0)
                    CS_CrockPotListAddFood("水果拼盘", 0)
                Else
                    CS_CrockPotListAddFood("水果拼盘", 0)
                End If
            End If
        End If
        If CS_FT_Meats >= 3 And CS_FT_Twigs = 0 Then
            CS_CrockPotListAddFood("肉汤", 0)
        End If
        If CS_FT_Meats >= 0.5 And CS_FT_Meats < 3 And CS_FT_Twigs = 0 Then
            CS_CrockPotListAddFood("肉丸", -1)
        End If

        REM 食物判断
        If CrockPotListIndex = -1 Then
            CS_F_name = "湿腻焦糊"
            CS_image_Food_5_Source("F_wet_goop")
        Else
            CS_F_name = CrockPotList(0)
            Select Case CrockPotList(0)
                Case "新鲜水果薄饼"
                    CS_image_Food_5_Source("F_fresh_fruit_crepes")
                Case "怪物鞑靼"
                    CS_image_Food_5_Source("F_monster_tartare")
                Case "贝类淡菜汤"
                    CS_image_Food_5_Source("F_mussel_bouillabaise")
                Case "薯蛋奶酥"
                    CS_image_Food_5_Source("F_sweet_potato_souffle")
                Case "龙虾浓汤"
                    CS_image_Food_5_Source("F_lobster_bisque")
                Case "汤"
                    CS_image_Food_5_Source("F_bisque")
                Case "咖啡"
                    CS_image_Food_5_Source("F_coffee")
                Case "海鲜牛排"
                    CS_image_Food_5_Source("F_surf_'n'_turf")
                Case "龙虾正餐"
                    CS_image_Food_5_Source("F_lobster_dinner")
                Case "香蕉冰淇淋"
                    CS_image_Food_5_Source("F_banana_pop")
                Case "加州卷"
                    CS_image_Food_5_Source("F_california_roll")
                Case "果冻冰淇淋"
                    CS_image_Food_5_Source("F_jelly-O_pop")
                Case "橘汁腌鱼"
                    CS_image_Food_5_Source("F_ceviche")
                Case "鱼翅汤"
                    CS_image_Food_5_Source("F_shark_fin_soup")
                Case "海鲜汤"
                    CS_image_Food_5_Source("F_seafood_gumbo")
                Case "鼹鼠鳄梨酱"
                    CS_image_Food_5_Source("F_guacamole")
                Case "花瓣沙拉"
                    CS_image_Food_5_Source("F_flower_salad")
                Case "冰淇淋"
                    CS_image_Food_5_Source("F_ice_cream")
                Case "西瓜冰"
                    CS_image_Food_5_Source("F_melonsicle")
                Case "水果杂烩"
                    CS_image_Food_5_Source("F_trail_mix")
                Case "辣椒酱"
                    CS_image_Food_5_Source("F_spicy_chili")
                Case "鳗鱼"
                    CS_image_Food_5_Source("F_unagi")
                Case "南瓜饼"
                    CS_image_Food_5_Source("F_pumpkin_cookie")
                Case "芝士蛋糕"
                    CS_image_Food_5_Source("F_powdercake")
                Case "曼德拉汤"
                    CS_image_Food_5_Source("F_mandrake_soup")
                Case "炸鱼条"
                    CS_image_Food_5_Source("F_fishsticks")
                Case "玉米饼包炸鱼"
                    CS_image_Food_5_Source("F_fish_tacos")
                Case "培根煎蛋"
                    CS_image_Food_5_Source("F_bacon_and_eggs")
                Case "火鸡正餐"
                    CS_image_Food_5_Source("F_turkey_dinner")
                Case "太妃糖"
                    CS_image_Food_5_Source("F_taffy")
                Case "华夫饼"
                    CS_image_Food_5_Source("F_waffles")
                Case "怪物千层饼"
                    CS_image_Food_5_Source("F_monster_lasagna")
                Case "饺子"
                    CS_image_Food_5_Source("F_pierogi")
                Case "肉串"
                    CS_image_Food_5_Source("F_kabobs")
                Case "蜜汁火腿"
                    CS_image_Food_5_Source("F_honey_ham")
                Case "甜蜜金砖"
                    CS_image_Food_5_Source("F_honey_nuggets")
                Case "奶油松饼"
                    CS_image_Food_5_Source("F_butter_muffin")
                Case "青蛙圆面包三明治"
                    CS_image_Food_5_Source("F_froggle_bunwich")
                Case "火龙果派"
                    CS_image_Food_5_Source("F_dragonpie")
                Case "香酥茄盒"
                    CS_image_Food_5_Source("F_stuffed_eggplant")
                Case "蔬菜杂烩"
                    CS_image_Food_5_Source("F_ratatouille")
                Case "果酱蜜饯"
                    CS_image_Food_5_Source("F_fist_full_of_jam")
                Case "水果拼盘"
                    CS_image_Food_5_Source("F_fruit_medley")
                Case "肉汤"
                    CS_image_Food_5_Source("F_meaty_stew")
                Case "肉丸"
                    CS_image_Food_5_Source("F_meatballs")
            End Select
        End If

        REM 选择按钮显示判断
        If CrockPotListIndex < 1 Then
            button_CS_Switch_Left.Visibility = Visibility.Collapsed
            button_CS_Switch_Right.Visibility = Visibility.Collapsed
        Else
            button_CS_Switch_Left.Visibility = Visibility.Visible
            button_CS_Switch_Right.Visibility = Visibility.Visible
            button_CS_Switch_Left.IsEnabled = False
            button_CS_Switch_Right.IsEnabled = True
        End If

        REM 显示食物名称
        TextBlock_CS_FoodName.Text = CS_F_name
        TextBlock_CS_FoodName.UpdateLayout()
        Dim CS_FoodName_MarginLeft As Integer
        CS_FoodName_MarginLeft = (Canvas_CookingSimulatorLeft.ActualWidth - TextBlock_CS_FoodName.ActualWidth) / 2
        Dim CS_FoodName_T As New Thickness()
        CS_FoodName_T.Top = 555
        CS_FoodName_T.Left = CS_FoodName_MarginLeft
        TextBlock_CS_FoodName.Margin = CS_FoodName_T
        REM 自动清空材料
        If checkBox_CS_AutoClean.IsChecked = True Then
            CS_Recipe_1 = ""
            CS_Recipe_2 = ""
            CS_Recipe_3 = ""
            CS_Recipe_4 = ""
            CS_image_Food_1.Source = Picture_Short_Name()
            CS_image_Food_2.Source = Picture_Short_Name()
            CS_image_Food_3.Source = Picture_Short_Name()
            CS_image_Food_4.Source = Picture_Short_Name()
        End If
    End Sub

    Private Sub button_CS_Food_1_5_click(sender As Object, e As RoutedEventArgs) Handles button_CS_Food_1_5.Click
        If CS_F_name <> "" Then
            LeftTabItem_Food.IsSelected = True
            Select Case CS_F_name
                Case "海鲜牛排"
                    Call button_F_surf_n_turf_click(Nothing, Nothing)
                Case "龙虾浓汤"
                    Call button_F_lobster_bisque_click(Nothing, Nothing)
                Case "咖啡"
                    Call button_F_coffee_click(Nothing, Nothing)
                Case "薯蛋奶酥"
                    Call button_F_sweet_potato_souffle_click(Nothing, Nothing)
                Case "怪物鞑靼"
                    Call button_F_monster_tartare_click(Nothing, Nothing)
                Case "贝类淡菜汤"
                    Call button_F_mussel_bouillabaise_click(Nothing, Nothing)
                Case "新鲜水果薄饼"
                    Call button_F_fresh_fruit_crepes_click(Nothing, Nothing)
                Case "汤"
                    Call button_F_bisque_click(Nothing, Nothing)
                Case "龙虾正餐"
                    Call button_F_lobster_dinner_click(Nothing, Nothing)
                Case "香蕉冰淇淋"
                    Call button_F_banana_pop_click(Nothing, Nothing)
                Case "鱼翅汤"
                    Call button_F_shark_fin_soup_click(Nothing, Nothing)
                Case "鳗鱼"
                    Call button_F_unagi_click(Nothing, Nothing)
                Case "橘汁腌鱼"
                    Call button_F_ceviche_click(Nothing, Nothing)
                Case "加州卷"
                    Call button_F_california_roll_click(Nothing, Nothing)
                Case "果冻冰淇淋"
                    Call button_F_jelly_O_pop_click(Nothing, Nothing)
                Case "海鲜汤"
                    Call button_F_seafood_gumbo_click(Nothing, Nothing)
                Case "南瓜饼"
                    Call button_F_pumpkin_cookie_click(Nothing, Nothing)
                Case "芝士蛋糕"
                    Call button_F_powdercake_click(Nothing, Nothing)
                Case "炸鱼条"
                    Call button_F_fishsticks_click(Nothing, Nothing)
                Case "玉米饼包炸鱼"
                    Call button_F_fish_tacos_click(Nothing, Nothing)
                Case "培根煎蛋"
                    Call button_F_bacon_and_eggs_click(Nothing, Nothing)
                Case "火鸡正餐"
                    Call button_F_turkey_dinner_click(Nothing, Nothing)
                Case "太妃糖"
                    Call button_F_taffy_click(Nothing, Nothing)
                Case "华夫饼"
                    Call button_F_waffles_click(Nothing, Nothing)
                Case "鼹鼠鳄梨酱"
                    Call button_F_guacamole_click(Nothing, Nothing)
                Case "花瓣沙拉"
                    Call button_F_flower_salad_click(Nothing, Nothing)
                Case "冰淇淋"
                    Call button_F_ice_cream_click(Nothing, Nothing)
                Case "西瓜冰"
                    Call button_F_melonsicle_click(Nothing, Nothing)
                Case "水果杂烩"
                    Call button_F_trail_mix_click(Nothing, Nothing)
                Case "辣椒酱"
                    Call button_F_spicy_chili_click(Nothing, Nothing)
                Case "曼德拉汤"
                    Call button_F_mandrake_soup_click(Nothing, Nothing)
                Case "怪物千层饼"
                    Call button_F_monster_lasagna_click(Nothing, Nothing)
                Case "饺子"
                    Call button_F_pierogi_click(Nothing, Nothing)
                Case "肉串"
                    Call button_F_kabobs_click(Nothing, Nothing)
                Case "蜜汁火腿"
                    Call button_F_honey_ham_click(Nothing, Nothing)
                Case "甜蜜金砖"
                    Call button_F_honey_nuggets_click(Nothing, Nothing)
                Case "奶油松饼"
                    Call button_F_butter_muffin_click(Nothing, Nothing)
                Case "青蛙圆面包三明治"
                    Call button_F_froggle_bunwich_click(Nothing, Nothing)
                Case "火龙果派"
                    Call button_F_dragonpie_click(Nothing, Nothing)
                Case "香酥茄盒"
                    Call button_F_stuffed_eggplant_click(Nothing, Nothing)
                Case "蔬菜杂烩"
                    Call button_F_ratatouille_click(Nothing, Nothing)
                Case "果酱蜜饯"
                    Call button_F_fist_full_of_jam_click(Nothing, Nothing)
                Case "水果拼盘"
                    Call button_F_fruit_medley_click(Nothing, Nothing)
                Case "肉汤"
                    Call button_F_meaty_stew_click(Nothing, Nothing)
                Case "肉丸"
                    Call button_F_meatballs_click(Nothing, Nothing)
                Case "湿腻焦糊"
                    Call button_F_wet_goop_click(Nothing, Nothing)
            End Select
        End If
    End Sub

    REM 食物DLC检测初始化
    Private Sub CS_DLC_Check_initialization()
        REM 肉类
        button_CS_tropical_fish.Visibility = Visibility.Collapsed
        button_CS_fish_morsel.Visibility = Visibility.Collapsed
        button_CS_cooked_fish_morsel.Visibility = Visibility.Collapsed
        button_CS_jellyfish.Visibility = Visibility.Collapsed
        button_CS_dead_jellyfish.Visibility = Visibility.Collapsed
        button_CS_cooked_jellyfish.Visibility = Visibility.Collapsed
        button_CS_dried_jellyfish.Visibility = Visibility.Collapsed
        button_CS_moleworm.Visibility = Visibility.Collapsed
        button_CS_limpets.Visibility = Visibility.Collapsed
        button_CS_cooked_limpets.Visibility = Visibility.Collapsed
        button_CS_mussel.Visibility = Visibility.Collapsed
        button_CS_cooked_mussel.Visibility = Visibility.Collapsed
        button_CS_dead_dogfish.Visibility = Visibility.Collapsed
        button_CS_wobster.Visibility = Visibility.Collapsed
        button_CS_raw_fish.Visibility = Visibility.Collapsed
        button_CS_fish_steak.Visibility = Visibility.Collapsed
        button_CS_shark_fin.Visibility = Visibility.Collapsed
        REM 蔬菜
        button_CS_cactus_flesh.Visibility = Visibility.Collapsed
        button_CS_cooked_cactus_flesh.Visibility = Visibility.Collapsed
        button_CS_cactus_flower.Visibility = Visibility.Collapsed
        button_CS_sweet_potato.Visibility = Visibility.Collapsed
        button_CS_cooked_sweet_potato.Visibility = Visibility.Collapsed
        button_CS_seaweed.Visibility = Visibility.Collapsed
        button_CS_roasted_seaweed.Visibility = Visibility.Collapsed
        button_CS_dried_seaweed.Visibility = Visibility.Collapsed
        REM 水果
        button_CS_juicy_berries.Visibility = Visibility.Collapsed
        button_CS_roasted_juicy_berries.Visibility = Visibility.Collapsed
        button_CS_roasted_coconut.Visibility = Visibility.Collapsed
        button_CS_halved_coconut.Visibility = Visibility.Collapsed
        REM 蛋类
        button_CS_doydoy_egg.Visibility = Visibility.Collapsed
        button_CS_fried_doydoy_egg.Visibility = Visibility.Collapsed
        REM 其他
        button_CS_electric_milk.Visibility = Visibility.Collapsed
        button_CS_roasted_birchnut.Visibility = Visibility.Collapsed
        button_CS_butterfly_wing_sw.Visibility = Visibility.Collapsed
        button_CS_coffee_beans.Visibility = Visibility.Collapsed
        button_CS_roasted_coffee_beans.Visibility = Visibility.Collapsed
    End Sub

    Private Sub CS_DLC_ROG_SHOW()
        REM 肉类
        button_CS_moleworm.Visibility = Visibility.Visible
        REM 蔬菜
        button_CS_cactus_flesh.Visibility = Visibility.Visible
        button_CS_cooked_cactus_flesh.Visibility = Visibility.Visible
        button_CS_cactus_flower.Visibility = Visibility.Visible
        REM 水果
        REM 其他
        button_CS_electric_milk.Visibility = Visibility.Visible
        button_CS_roasted_birchnut.Visibility = Visibility.Visible
    End Sub

    Private Sub CS_DLC_SW_SHOW()
        REM 肉类
        button_CS_tropical_fish.Visibility = Visibility.Visible
        button_CS_fish_morsel.Visibility = Visibility.Visible
        button_CS_cooked_fish_morsel.Visibility = Visibility.Visible
        button_CS_jellyfish.Visibility = Visibility.Visible
        button_CS_dead_jellyfish.Visibility = Visibility.Visible
        button_CS_cooked_jellyfish.Visibility = Visibility.Visible
        button_CS_dried_jellyfish.Visibility = Visibility.Visible
        button_CS_limpets.Visibility = Visibility.Visible
        button_CS_cooked_limpets.Visibility = Visibility.Visible
        button_CS_mussel.Visibility = Visibility.Visible
        button_CS_cooked_mussel.Visibility = Visibility.Visible
        button_CS_dead_dogfish.Visibility = Visibility.Visible
        button_CS_wobster.Visibility = Visibility.Visible
        button_CS_raw_fish.Visibility = Visibility.Visible
        button_CS_fish_steak.Visibility = Visibility.Visible
        button_CS_shark_fin.Visibility = Visibility.Visible
        REM 蔬菜
        button_CS_sweet_potato.Visibility = Visibility.Visible
        button_CS_cooked_sweet_potato.Visibility = Visibility.Visible
        button_CS_seaweed.Visibility = Visibility.Visible
        button_CS_roasted_seaweed.Visibility = Visibility.Visible
        button_CS_dried_seaweed.Visibility = Visibility.Visible
        REM 水果
        button_CS_roasted_coconut.Visibility = Visibility.Visible
        button_CS_halved_coconut.Visibility = Visibility.Visible
        REM 蛋类
        button_CS_doydoy_egg.Visibility = Visibility.Visible
        button_CS_fried_doydoy_egg.Visibility = Visibility.Visible
        REM 其他
        button_CS_butterfly_wing_sw.Visibility = Visibility.Visible
        button_CS_coffee_beans.Visibility = Visibility.Visible
        button_CS_roasted_coffee_beans.Visibility = Visibility.Visible
    End Sub

    Private Sub CS_DLC_DST_SHOW()
        REM 肉类
        button_CS_moleworm.Visibility = Visibility.Visible
        REM 蔬菜
        button_CS_cactus_flesh.Visibility = Visibility.Visible
        button_CS_cooked_cactus_flesh.Visibility = Visibility.Visible
        button_CS_cactus_flower.Visibility = Visibility.Visible
        REM 水果
        button_CS_juicy_berries.Visibility = Visibility.Visible
        button_CS_roasted_juicy_berries.Visibility = Visibility.Visible
        REM 其他
        button_CS_electric_milk.Visibility = Visibility.Visible
        button_CS_roasted_birchnut.Visibility = Visibility.Visible
    End Sub

    REM 食物DLC检测
    Private Sub CS_DLC_Check()
        CS_DLC_Check_initialization()

        Dim CS_ROG__ As SByte
        Dim CS_SW__ As SByte
        Dim CS_DST__ As SByte
        If checkBox_CS_DLC_ROG.IsChecked = True Then
            CS_ROG__ = 1
        Else
            CS_ROG__ = 0
        End If
        If checkBox_CS_DLC_SW.IsChecked = True Then
            CS_SW__ = 2
        Else
            CS_SW__ = 0
        End If
        If checkBox_CS_DLC_DST.IsChecked = True Then
            CS_DST__ = 4
        Else
            CS_DST__ = 0
        End If
        CS_ROG_SW_DST = CS_ROG__ + CS_SW__ + CS_DST__
        If CS_ROG_SW_DST = 0 Then
            MsgBox("至少选择一项！")
            checkBox_CS_DLC_ROG.IsChecked = True
            CS_DLC_Check()
        Else
            Select Case CS_ROG_SW_DST
                Case 1
                    CS_DLC_ROG_SHOW()
                    WrapPanel_CS_meats.Height = 170
                    WrapPanel_CS_others.Height = 90
                    WrapPanel_CookingSimulator.Height = 940
                    Reg_Write("Cooking_Simulator", 1)
                Case 2
                    CS_DLC_SW_SHOW()
                    WrapPanel_CS_meats.Height = 250
                    WrapPanel_CS_others.Height = 90
                    WrapPanel_CookingSimulator.Height = 1020
                    Reg_Write("Cooking_Simulator", 2)
                Case 3
                    CS_DLC_ROG_SHOW()
                    CS_DLC_SW_SHOW()
                    WrapPanel_CS_meats.Height = 330
                    WrapPanel_CS_others.Height = 170
                    WrapPanel_CookingSimulator.Height = 1180
                    Reg_Write("Cooking_Simulator", 3)
                Case 4
                    CS_DLC_DST_SHOW()
                    WrapPanel_CS_meats.Height = 170
                    WrapPanel_CS_others.Height = 90
                    WrapPanel_CookingSimulator.Height = 940
                    Reg_Write("Cooking_Simulator", 4)
                Case 5
                    CS_DLC_ROG_SHOW()
                    CS_DLC_DST_SHOW()
                    WrapPanel_CS_meats.Height = 170
                    WrapPanel_CS_others.Height = 90
                    WrapPanel_CookingSimulator.Height = 940
                    Reg_Write("Cooking_Simulator", 5)
                Case 6
                    CS_DLC_SW_SHOW()
                    CS_DLC_DST_SHOW()
                    WrapPanel_CS_meats.Height = 330
                    WrapPanel_CS_others.Height = 170
                    WrapPanel_CookingSimulator.Height = 1180
                    Reg_Write("Cooking_Simulator", 6)
                Case 7
                    CS_DLC_ROG_SHOW()
                    CS_DLC_SW_SHOW()
                    CS_DLC_DST_SHOW()
                    WrapPanel_CS_meats.Height = 330
                    WrapPanel_CS_others.Height = 170
                    WrapPanel_CookingSimulator.Height = 1180
                    Reg_Write("Cooking_Simulator", 7)
            End Select
        End If
    End Sub

    Private Sub CS_CHECKBOX_()
        button_CS_Switch_Left.Visibility = Visibility.Collapsed
        button_CS_Switch_Right.Visibility = Visibility.Collapsed
        CS_Recipe_1 = ""
        CS_Recipe_2 = ""
        CS_Recipe_3 = ""
        CS_Recipe_4 = ""
        CS_image_Food_1.Source = Picture_Short_Name()
        CS_image_Food_2.Source = Picture_Short_Name()
        CS_image_Food_3.Source = Picture_Short_Name()
        CS_image_Food_4.Source = Picture_Short_Name()
        CS_image_Food_5.Source = Picture_Short_Name()
        TextBlock_CS_FoodName.Text = ""
        CS_F_name = ""
    End Sub

    Private Sub button_CS_Reset_click(sender As Object, e As RoutedEventArgs) Handles button_CS_Reset.Click
        CS_CHECKBOX_()
    End Sub

    Private Sub checkBox_CS_DLC_ROG_click(sender As Object, e As RoutedEventArgs) Handles checkBox_CS_DLC_ROG.Click
        CS_CHECKBOX_()
        CS_DLC_Check()
    End Sub

    Private Sub FL_button_CS_DLC_ROG_click(sender As Object, e As RoutedEventArgs) Handles FL_button_CS_DLC_ROG.Click
        If checkBox_CS_DLC_ROG.IsChecked = True Then
            checkBox_CS_DLC_ROG.IsChecked = False
        Else
            checkBox_CS_DLC_ROG.IsChecked = True
        End If
        checkBox_CS_DLC_ROG_click(Nothing, Nothing)
    End Sub

    Private Sub checkBox_CS_DLC_SW_click(sender As Object, e As RoutedEventArgs) Handles checkBox_CS_DLC_SW.Click
        CS_CHECKBOX_()
        CS_DLC_Check()
    End Sub

    Private Sub FL_button_CS_DLC_SW_click(sender As Object, e As RoutedEventArgs) Handles FL_button_CS_DLC_SW.Click
        If checkBox_CS_DLC_SW.IsChecked = True Then
            checkBox_CS_DLC_SW.IsChecked = False
        Else
            checkBox_CS_DLC_SW.IsChecked = True
        End If
        checkBox_CS_DLC_SW_click(Nothing, Nothing)
    End Sub

    Private Sub checkBox_CS_DLC_DST_click(sender As Object, e As RoutedEventArgs) Handles checkBox_CS_DLC_DST.Click
        CS_CHECKBOX_()
        CS_DLC_Check()
    End Sub

    Private Sub FL_button_CS_DLC_DST_click(sender As Object, e As RoutedEventArgs) Handles FL_button_CS_DLC_DST.Click
        If checkBox_CS_DLC_DST.IsChecked = True Then
            checkBox_CS_DLC_DST.IsChecked = False
        Else
            checkBox_CS_DLC_DST.IsChecked = True
        End If
        checkBox_CS_DLC_DST_click(Nothing, Nothing)
    End Sub
#End Region

#Region "生物"

    REM ------------------生物(陆地生物)-------------------
    Private Sub button_A_prime_ape_click(sender As Object, e As RoutedEventArgs) Handles button_A_prime_ape.Click
        Dim LootHeight As Integer = A_Loot("F_morsel", "1(50%)", "F_banana", "1(50%)", "G_manure", "1(如果生产了且没抛)", "", "任何捡起且未消耗的物品")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "偷东西", "抛便便", "喂食香蕉可以做朋友")
        A_Show("猿猴", "Prime Ape", "A_prime_ape", "SW", 0, 1, 0, 125, 0, 20, 2, 3, 7, 7, 3, 0, False, True, "", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_spider_warrior_sw_click(sender As Object, e As RoutedEventArgs) Handles button_A_spider_warrior_sw.Click
        Dim LootHeight As Integer = A_Loot("F_monster_meat", "1(50%)", "G_silk", "1(25%)", "G_venom_gland", "1(25%)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "跳跃攻击", "攻击带毒")
        A_Show("毒蜘蛛", "Spider Warrior", "A_spider_warrior_sw", "SW", 0, 1, 0, 200, 0, 20, 4, 6, 4, 5, 4, -40, True, True, "船难版的战斗蜘蛛，除了攻击带毒没有什么两样。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_fishermerm_click(sender As Object, e As RoutedEventArgs) Handles button_A_fishermerm.Click
        Dim LootHeight As Integer = A_Loot("F_tropical_fish", "1")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("渔人", "Fishermerm", "A_fishermerm", "SW", 0, 1, 0, 150, 0, 0, 0, 0, 0, 0, 0, 0, False, False, "渔人是船难版的鱼人，通常能在沼泽发现，不同的是，它们不会攻击，遇到玩家会逃跑。定期从潮汐池中捞出热带鱼但是并不吃。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_flup_click(sender As Object, e As RoutedEventArgs) Handles button_A_flup.Click
        Dim LootHeight As Integer = A_Loot("F_monster_meat", "1", "G_eyeshot", "1(25%)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("追踪性弹涂鱼", "Flup", "A_flup", "SW", 0, 1, 0, 100, 0, 25, 0, 0, 4, 6.5, 3, 0, True, True, "追踪性弹涂鱼会出现在潮滩，类似于触手，它们会隐藏在泥里，等待生物经过惊吓它们。仔细观察可以看到它们伸出来的眼睛或者气泡，如果预先提防就不容易被攻击。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_crabbit_click(sender As Object, e As RoutedEventArgs) Handles button_A_crabbit.Click
        Dim LootHeight As Integer = A_Loot("F_fish_morsel", "1", "A_crabbit", "陷阱")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("兔蟹", "Crabbit", "A_crabbit", "SW", 0, 1, 0, 50, 0, 0, 0, 0, 1.5, 5, 0, 0, False, False, "船难版的兔子。与兔子不同的是，被追击太久不会优先回家，而是创造一个流沙把自己埋起来，保护自己免受伤害。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_beardling_sw_click(sender As Object, e As RoutedEventArgs) Handles button_A_beardling_sw.Click
        Dim LootHeight As Integer = A_Loot("F_monster_meat", "1(40%)", "G_nightmare_fuel", "1(40%)", "G_beard_hair", "1(20%)", "A_beardling_sw", "陷阱")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("黑兔蟹", "Crabbit", "A_beardling_sw", "SW", 0, 1, 0, 50, 0, 0, 0, 0, 1.5, 5, 0, -40, False, False, "玩家精神低于40%时兔蟹会变成黑兔蟹，掉落物会有所变化，其他行为没有变化。当玩家精神回复到40%以上又会变回兔蟹。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_baby_doydoy_click(sender As Object, e As RoutedEventArgs) Handles button_A_baby_doydoy.Click
        Dim LootHeight As Integer = A_Loot("F_morsel", "1", "G_doydoy_feather", "1")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "吃种子", "成长为渡渡鸟")
        A_Show("幼小的渡渡鸟", "Baby Doydoy", "A_baby_doydoy", "SW", 0, 1, 0, 25, 0, 0, 0, 0, 5, 5, 0, 0, False, False, "只吃种子，过两天成长为小渡渡鸟。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_doydoy_child_click(sender As Object, e As RoutedEventArgs) Handles button_A_doydoy_child.Click
        Dim LootHeight As Integer = A_Loot("F_drumstick", "1", "G_doydoy_feather", "2")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "吃种子和蔬菜", "成长为渡渡鸟")
        A_Show("小渡渡鸟", "Doydoy Child", "A_doydoy_child", "SW", 0, 1, 0, 75, 0, 0, 0, 0, 1.5, 1.5, 0, 0, False, False, "吃种子和蔬菜，过一天成长为渡渡鸟。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_doydoy_click(sender As Object, e As RoutedEventArgs) Handles button_A_doydoy.Click
        Dim LootHeight As Integer = A_Loot("F_meat", "1", "F_drumstick", "2", "G_doydoy_feather", "2")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "吃看到的任何食物除了自己的蛋(包括农场和锅里)")
        A_Show("渡渡鸟", "Doydoy", "A_doydoy", "SW", 0, 1, 0, 100, 0, 0, 0, 0, 2, 2, 0, 0, False, False, "一个地图会有两只渡渡鸟生成在不同的岛上(通常是丛林岛)。渡渡鸟夜晚会睡觉，当它睡觉时可以捡起(在身上时会吃身上的东西)。杀人蜂和蜘蛛会忽视渡渡鸟，而蛇、龙骑士和猎犬都会主动攻击渡渡鸟，需要保护它们免受攻击。每过两到三天在一起的两只渡渡鸟会配对成情侣，除非已经有20只渡渡鸟，配对后会产生一个渡渡鸟巢，若不采集就会生出幼小的渡渡鸟。渡渡鸟被攻击时不会逃跑，存在的数量越少击杀渡渡鸟增加的顽皮值越高。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_snake_click(sender As Object, e As RoutedEventArgs) Handles button_A_snake.Click
        Dim LootHeight As Integer = A_Loot("F_monster_meat", "1(33%)", "G_snakeskin", "1(16%)", "G_snake_oil", "1(0.33%)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("蛇", "Snake", "A_snake", "SW", 0, 1, 0, 100, 0, 10, 3, 0, 3, 3, 1, -40, True, True, "蛇有可能出生在藤蔓丛或浆果灌木丛，砍倒丛林树也有可能会出现。蛇通常出现在黄昏和夜晚，除非玩家砍伐丛林树或砍伐藤蔓从。蛇有时候会吃地上的肉和蛋。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_poison_snake_click(sender As Object, e As RoutedEventArgs) Handles button_A_poison_snake.Click
        Dim LootHeight As Integer = A_Loot("F_monster_meat", "1(20%)", "G_venom_gland", "1(20%)", "G_snakeskin", "1(10%)", "G_snake_oil", "1(0.2%)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "攻击带毒")
        A_Show("毒蛇", "Poison Snake", "A_poison_snake", "SW", 0, 1, 0, 100, 0, 10, 3, 2.5, 3, 3, 2, -40, True, True, "毒蛇类似于蛇，不过攻击附带毒性，如果毒蛇咬到将会每秒失去1.5的生命，除非用抗蛇毒血清解毒(击杀毒蛇有几率掉落抗蛇毒血清的制作材料毒腺体)。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_dragoon_click(sender As Object, e As RoutedEventArgs) Handles button_A_dragoon.Click
        Dim LootHeight As Integer = A_Loot("F_monster_meat", "1", "F_dragoon_heart", "1(10%)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "火焰冲刺")
        A_Show("龙骑士", "Dragoon", "A_dragoon", "SW", 0, 1, 0, 300, 0, 25, 1, 0, 3, 15, 3, 0, True, False, "龙骑士出生于龙人巢或孵化于完整的龙人蛋，它们只在白天外出，如果有龙人巢的话黄昏会回龙人巢，空闲的时候会在地上吐熔岩。进入战斗后它们会冲向攻击目标并且在经过的路上留下火焰。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_elephant_cactus_click(sender As Object, e As RoutedEventArgs) Handles button_A_elephant_cactus.Click
        Dim LootHeight As Integer = A_Loot("G_cactus_spike", "1")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "范围攻击", "反击")
        A_Show("刺人的象仙人掌", "Prickly Elephant Cactus", "A_elephant_cactus", "SW", 0, 1, 0, 400, 0, 20, 2, 5, 0, 0, 2, 0, True, False, "天然刺人的象仙人掌只存在于火山，它们会范围攻击，并且攻击它的时候会反弹10点伤害，缺点是不会动，并且只在干旱季节才活跃，其他季节会枯萎。击杀后获得的仙人掌可以移植，不过只能移植在岩浆草皮、灰色的草皮和火山草皮上，用灰烬灌溉。", LootHeight, SpecialAbilityHeight)
    End Sub

    REM ------------------生物(海洋生物)-------------------
    Private Sub button_A_dogfish_click(sender As Object, e As RoutedEventArgs) Handles button_A_dogfish.Click
        Dim LootHeight As Integer = A_Loot("F_dead_dogfish", "1")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("狗鱼", "Dogfish", "A_dogfish", "SW", 0, 1, 0, 100, 0, 0, 0, 0, 5, 8, 0, 0, False, False, "通常发现在海洋中和珊瑚礁旁，当船靠近会飞快游走。可以用矛枪或者逼到岸边角落击杀。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_swordfish_click(sender As Object, e As RoutedEventArgs) Handles button_A_swordfish.Click
        Dim LootHeight As Integer = A_Loot("F_dead_swordfish", "1")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("旗鱼", "Swordfish", "A_swordfish", "SW", 0, 1, 0, 200, 0, 30, 2, 0, 5, 8, 3, 0, True, False, "旗鱼通常被发现于深海中，一旦发现玩家会追杀玩家。在其出现时可以放一个浮标之类的东西标记一下。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_wobster_click(sender As Object, e As RoutedEventArgs) Handles button_A_wobster.Click
        Dim LootHeight As Integer = A_Loot("F_dead_wobster", "1")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("龙虾", "Wobster", "A_wobster", "SW", 0, 1, 0, 25, 0, 0, 0, 0, 1.5, 4, 0, 0, False, False, "龙虾出现在龙虾的巢穴附近，一个巢穴一只龙虾，黄昏和夜晚才会出来，玩家靠近它就会跑回巢穴里。可以用拖网或海洋陷阱捕捉。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_bioluminescence_click(sender As Object, e As RoutedEventArgs) Handles button_A_bioluminescence.Click
        Dim LootHeight As Integer = A_Loot("G_bioluminescence", "捕虫网", "G_bioluminescence", "拖网")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "发光")
        A_Show("海洋生物", "Bioluminescence", "A_bioluminescence", "SW", 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, False, False, "通常会在深海发现，12个一组可以认为是海洋中的萤火虫，但是玩家靠近它不会消失，可以用拖网或捕虫网捕捉。注意放在陆地上会被摧毁，放在海里才可以生存。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_jellyfish_click(sender As Object, e As RoutedEventArgs) Handles button_A_jellyfish.Click
        Dim LootHeight As Integer = A_Loot("F_dead_jellyfish", "1", "F_jellyfish", "拖网", "F_jellyfish", "捕虫网")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "使攻击它的玩家触电")
        A_Show("水母", "Jellyfish", "A_jellyfish", "SW", 0, 1, 0, 50, 0, 5, 0, 0, 2, 2, 0, 0, False, False, "可以在浅海区域找到它们，有时候会成群出现。攻击它会触电，可以用捕虫网或拖网直接捕获，也可以用蛇鳞帽或蛇鳞上衣防电。放在地上会直接死亡。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_bottenosed_ballphin_click(sender As Object, e As RoutedEventArgs) Handles button_A_bottenosed_ballphin.Click
        Dim LootHeight As Integer = A_Loot("F_fish_morsel", "2", "S_empty_bottle", "1(50%)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("宽吻海豚", "Bottlenosed Ballphin", "A_bottenosed_ballphin", "SW", 0, 1, 0, 100, 0, 10, 6, 0, 5, 8, 1, 0, False, True, "可以在海洋的任何地方发现宽吻海豚，一般12个一组，在第15~16天才会出现。如果一组中的一部分被杀害，会在温和季节重生，如果一组中只剩一只，那么它会跟着玩家到一片新的海域，不过路上很容易分心。它们会攻击任何敌对生物(如恶臭魔鬼鱼或海狗)。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_blue_whale_click(sender As Object, e As RoutedEventArgs) Handles button_A_blue_whale.Click
        Dim LootHeight As Integer = A_Loot("A_blue_whale_carcass", "1")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "蓝鲸尸体战利品：", "生鱼片×4", "鲸油×4", "3~9样其他物品")
        A_Show("蓝鲸", "Blue Whale", "A_blue_whale", "SW", 0, 1, 0, 650, 0, 50, 3.5, 0, 2, 4, 4, 0, False, True, "有三分之二的几率可以通过可疑的泡泡(类似可疑的土堆)发现它，在被攻击之前它会尽量躲避玩家。被杀死后留下蓝鲸尸体，只有玩家在附近3~5天才能用砍刀切开获得战利品(火药可以加速腐烂)。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_white_whale_click(sender As Object, e As RoutedEventArgs) Handles button_A_white_whale.Click
        Dim LootHeight As Integer = A_Loot("A_white_whale_carcass", "1")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "白鲸尸体战利品：", "生鱼片×4", "鲸油×4", "鱼叉×1", "3~9样其他物品")
        A_Show("白鲸", "White Whale", "A_white_whale", "SW", 0, 1, 0, 800, 0, 75, 3, 0, 2.5, 5, 5, 0, True, False, "有三分之一的几率可以通过可疑的泡泡(类似可疑的土堆)发现它，玩家靠近就会一直追杀玩家。被杀死后留下白鲸尸体，只有玩家在附近3~5天才能用砍刀切开获得战利品。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_floaty_boaty_knight_click(sender As Object, e As RoutedEventArgs) Handles button_A_floaty_boaty_knight.Click
        Dim LootHeight As Integer = A_Loot("G_gears", "1~3")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "远程攻击*3")
        A_Show("浮船骑士", "Floaty Boaty Knight", "A_floaty_boaty_knight", "SW", 0, 1, 0, 500, 0, 50, 6, 0, 3, 6, 4, 0, True, False, "守护木制平台的生物，4只同时出现。也会在击杀任何海洋生物时有几率出现1~3只。一旦离玩家过近会拉开安全距离然后开始攻击(放炮)，一次性放出三个炮弹落在靠近玩家某一点附近的随机位置。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_stink_ray_click(sender As Object, e As RoutedEventArgs) Handles button_A_stink_ray.Click
        Dim LootHeight As Integer = A_Loot("G_venom_gland", "1(33%)", "F_monster_meat", "1(66%)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "排出有毒气体")
        A_Show("恶臭魔鬼鱼", "Stink Ray", "A_stink_ray", "SW", 0, 1, 0, 50, 0, 0, 1, 1.5, 8, 8, 1, 0, True, True, "恶臭魔鬼鱼通常6个一组出现在海上，它们没有攻击力，只会释放毒气使玩家中毒。戴着粉尘净化器或者使用WX-78可以免疫毒气。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_water_beefalo_click(sender As Object, e As RoutedEventArgs) Handles button_A_water_beefalo.Click
        Dim LootHeight As Integer = A_Loot("F_meat", "4", "G_horn", "1", "G_manure", "1(周期产生)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "春天生水牛", "上岸变成敌对")
        A_Show("水牛", "Water Beefalo", "A_water_beefalo", "SW", 0, 1, 0, 500, 0, 34, 4, 3, 1.5, 7.5, 3, 0, False, True, "和皮弗娄牛类似，不过无法对其使用剃刀，即没有牛毛，而且掉落的是角而不是牛角。它们通常生活在红树林，虽然一般都在水里，但也可以上岸，上岸后会主动攻击。", LootHeight, SpecialAbilityHeight)
    End Sub

    REM ------------------生物(飞行生物)-------------------
    Private Sub button_A_butterfly_sw_click(sender As Object, e As RoutedEventArgs) Handles button_A_butterfly_sw.Click
        Dim LootHeight As Integer = A_Loot("F_butterfly_wing_sw", "1(98%)", "F_butter", "1(2%)", "A_butterfly_sw", "捕虫网")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("船难蝴蝶", "Butterfly", "A_butterfly_sw", "SW", 0, 1, 0, 1, 0, 0, 0, 0, 5, 5, 0, 0, False, False, "除了外貌不同，和普通蝴蝶没什么区别。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_mosquito_sw_click(sender As Object, e As RoutedEventArgs) Handles button_A_mosquito_sw.Click
        Dim LootHeight As Integer = A_Loot("G_yellow_mosquito_sack", "1(50%)", "G_venom_gland", "1", "A_mosquito_sw", "捕虫网")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "吸完血后爆炸(伤害34)", "攻击带毒")
        A_Show("毒蚊子", "Poison Mosquito", "A_mosquito_sw", "SW", 0, 1, 0, 100, 0, 3, 2, 4, 8, 12, 1, 0, True, False, "毒蚊子出现于风季的水灾的潮水中或者坏结局的老虎机，成功攻击四次后自爆，对周围造成34点伤害。攻击附带毒性，要小心。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_parrot_click(sender As Object, e As RoutedEventArgs) Handles button_A_parrot.Click
        Dim LootHeight As Integer = A_Loot("F_morsel", "1(50%)", "G_crimson_feather", "1(50%)", "G_parrot", "捕鸟器")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "掉落种子", "吃种子")
        A_Show("鹦鹉", "Parrot", "A_parrot", "SW", 0, 1, 0, 25, 0, 0, 0, 0, 0, 0, 0, 0, False, False, "船难版中替代红雀的鸟类。囚禁在鸟笼里时，喂食熟怪兽肉会得到蛋，喂食作物可以得到1-2个作物种子和0-1个种子。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_parrot_pirate_click(sender As Object, e As RoutedEventArgs) Handles button_A_parrot_pirate.Click
        Dim LootHeight As Integer = A_Loot("F_morsel", "1(50%)", "G_crimson_feather", "1(50%)", "A_parrot_pirate", "捕鸟器")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "掉落金币")
        A_Show("海盗鹦鹉", "Parrot Pirate", "A_parrot_pirate", "SW", 0, 1, 0, 25, 0, 0, 0, 0, 0, 0, 0, 25, False, False, "一种特殊的鹦鹉，不会掉落种子，而是掉落金币。捕捉后关在笼子里有恢复精神光环。囚禁在鸟笼里时，喂食熟怪兽肉会得到蛋，喂食作物可以得到1-2个作物种子和0-1个种子。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_toucan_click(sender As Object, e As RoutedEventArgs) Handles button_A_toucan.Click
        Dim LootHeight As Integer = A_Loot("F_morsel", "1(50%)", "G_jet_feather", "1(50%)", "A_toucan", "捕鸟器")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "掉落种子", "吃种子")
        A_Show("大嘴鸟", "Toucan", "A_toucan", "SW", 0, 1, 0, 25, 0, 0, 0, 0, 0, 0, 0, 0, False, False, "船难版中替代乌鸦的鸟类。囚禁在鸟笼里时，喂食熟怪兽肉会得到蛋，喂食作物可以得到1-2个作物种子和0-1个种子。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_seagull_click(sender As Object, e As RoutedEventArgs) Handles button_A_seagull.Click
        Dim LootHeight As Integer = A_Loot("F_morsel", "1(50%)", "G_azure_feather", "1(50%)", "A_seagull", "捕鸟器")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "掉落种子", "吃种子")
        A_Show("海鸥", "Seagull", "A_seagull", "SW", 0, 1, 0, 25, 0, 0, 0, 0, 0, 0, 0, 0, False, False, "海鸥是杂食鸟类，会吃地上的肉和帽贝岩的帽贝。囚禁在鸟笼里时，喂食熟怪兽肉会得到蛋，喂食作物可以得到1-2个作物种子和0-1个种子。", LootHeight, SpecialAbilityHeight)
    End Sub

    REM ------------------生物(洞穴生物)-------------------

    REM ------------------生物(邪恶生物)-------------------
    Private Sub button_A_sea_hound_click(sender As Object, e As RoutedEventArgs) Handles button_A_sea_hound.Click
        Dim LootHeight As Integer = A_Loot("F_monster_meat", "1", "G_hound's_tooth", "1(12.5%)", "F_shark_fin", "1(12.5%)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("海狗", "Sea Hound", "A_sea_hound", "NoDLC", 1, 0, 1, 150, 0, 20, 1.5, 3, 10, 10, 3, -40, True, True, "在船难版里，如果猎犬进攻时间到了而玩家在海上的话，就会有海狗代替猎犬来发动进攻。其掉落的鱼翅可以做鱼翅汤和星芒头盔。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_krampus_sw_click(sender As Object, e As RoutedEventArgs) Handles button_A_krampus_sw.Click
        Dim LootHeight As Integer = A_Loot("F_monster_meat", "1", "G_charcoal", "2", "G_krampus_sack", "1(1%)", "", "偷取的任何物品")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "偷东西(包括箱子和背包里的东西)")
        A_Show("船难坎普斯", "Krampus", "A_krampus_sw", "SW", 0, 1, 0, 200, 0, 50, 1.2, 3, 7, 7, 4, 0, False, False, "坎普斯会在顽皮值到达一定值(31-50之间的随机值)的时候出现，出现后顽皮值置0。它的动作类似火鸡，避免靠近玩家，但是会偷取箱子里或者地上的所有东西，包括背包(除了眼骨、鱼骨、星-空、露西斧、薇洛的打火机、Abigail之花、一堆气球、魔杖、传送机零件底座等特殊物品，除非它们在背包里)。在晚上它会睡觉，可以很容易击杀它。每分钟(一天8分钟)会减少一点顽皮值，而用火、狗牙陷阱、蜜蜂地雷、火药击杀生物将不会增加顽皮值，因为这被认为是环境破坏导致生物死亡。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_pirate_ghost_click(sender As Object, e As RoutedEventArgs) Handles button_A_pirate_ghost.Click
        Dim LootHeight As Integer = A_Loot()
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("海盗的鬼魂", "Pirate Ghost", "A_pirate_ghost", "SW", 0, 1, 0, 200, 0, 15, 1.2, 1.5, 2, 2, 2, -40, True, False, "在船难版里海盗的鬼魂替代了鬼魂，用锤子砸沉船或者在潮湿的坟墓里钓鱼都有可能会出现海盗的鬼魂。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_mr_skittish_click(sender As Object, e As RoutedEventArgs) Handles button_A_mr_skittish.Click
        Dim LootHeight As Integer = A_Loot()
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("Skittish先生", "Mr.Skittish", "A_mr_skittish", "SW", 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, False, False, "船难版的Skits先生。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_swimming_horror_click(sender As Object, e As RoutedEventArgs) Handles button_A_swimming_horror.Click
        Dim LootHeight As Integer = A_Loot("G_nightmare_fuel", "1", "G_nightmare_fuel", "1(50%)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "被攻击时消失并在周围随机位置出现")
        A_Show("海洋影怪", "Swimming Horror", "A_swimming_horror", "SW", 0, 1, 0, 300, 0, 20, 2.5, 3, 3, 3, 4, -100, True, True, "海洋影怪可以在浅滩发现，它们会主动不停地追逐玩家，除非玩家离开浅滩或回到岸上。", LootHeight, SpecialAbilityHeight)
    End Sub

    REM ------------------生物(其他)-------------------
    Private Sub button_A_packim_baggims_click(sender As Object, e As RoutedEventArgs) Handles button_A_packim_baggims.Click
        Dim LootHeight As Integer = A_Loot("", "储存的物品")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "跟随鱼骨", "9格储物", "生命恢复", "食用其体内鱼类食物", "升级为胖鹈鹕/火焰鹈鹕")
        A_Show("鹈鹕", "Packim Baggims", "A_packim_baggims", "SW", 0, 1, 0, 450, 450, 0, 0, 0, 10, 10, 0, 0, False, False, "船难版的切斯特，会跟随鱼骨(可能在除了出生岛屿之外的其他任何岛屿)，它可以吃最基本的鱼类食品，拥有150的最大饥饿值，饥饿值每天减少48点，在饥饿的时候不会掉血。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_fat_packim_baggims_click(sender As Object, e As RoutedEventArgs) Handles button_A_fat_packim_baggims.Click
        Dim LootHeight As Integer = A_Loot("", "储存的物品")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "跟随鱼骨", "12格储物", "生命恢复", "食用其体内鱼类食物")
        A_Show("胖鹈鹕", "Fat Packim Baggims", "A_fat_packim_baggims", "SW", 0, 1, 0, 450, 450, 0, 0, 0, 10, 10, 0, 0, False, False, "当鹈鹕的饥饿值到达120以上时就会变成胖鹈鹕，拥有12个格子，此时当饥饿掉到0时又会变回普通鹈鹕，额外的三个格子里的物品会掉落下来。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_fire_packim_baggims_click(sender As Object, e As RoutedEventArgs) Handles button_A_fire_packim_baggims.Click
        Dim LootHeight As Integer = A_Loot("", "储存的物品")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "跟随鱼骨", "9格储物", "生命恢复", "火焰攻击附近怪物", "烹饪食物")
        A_Show("火焰鹈鹕", "Fire Packim Baggims", "A_fire_packim_baggims", "SW", 0, 1, 0, 450, 450, 0, 0, 0, 10, 10, 0, 0, False, False, "在鹈鹕的每个格子里放入至少一个黑曜石就会变成火焰鹈鹕，它免疫火并且会自动用远程火焰攻击怪物和敌对生物(包括韦伯)。它会自动烹煮食物，并且如果有易燃品那么就会变成灰烬。", LootHeight, SpecialAbilityHeight)
    End Sub

    REM ------------------生物(巨型生物)-------------------
    Private Sub button_A_palm_treeguard_click(sender As Object, e As RoutedEventArgs) Handles button_A_palm_treeguard.Click
        Dim LootHeight As Integer = A_Loot("G_living_log", "6", "F_coconut", "2", "F_monster_meat", "1(一定几率)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "抛椰子远程攻击")
        A_Show("椰树守卫", "Palm Treeguard", "A_palm_treeguard", "SW", 0, 1, 0, 750, 0, 150, 3, 3, 1.5, 1.5, 6, -100, True, True, "和树精守卫一样，砍伐椰子树就有几率出现椰树守卫，它们同样有3种大小，但是属性并没有变化。一旦产生，它们会保持永久敌对状态，离开当前岛屿再回来仇恨还是保持，除非种植丛林树种或椰子。椰树守卫有近程攻击和远程抛椰子攻击，抛椰子可以通过地上的影子躲避。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_quacken_click(sender As Object, e As RoutedEventArgs) Handles button_A_quacken.Click
        Dim LootHeight As Integer = A_Loot("N_chest_of_the_depths", "1", "N_booty_bag_1", "1", "G_iron_key", "1(仅第一次)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "墨水炸弹", "生成呱肯乌贼的触手")
        A_Show("呱肯乌贼", "Quacken", "A_quacken", "SW", 0, 1, 0, 1000, 0, 50, 7.5, 20, 0, 0, 6, 0, True, True, "呱肯乌贼是船难版的BOSS之一，用钓竿在潮湿的坟墓或者在深海用拖网就有机会召唤出呱肯乌贼，每一个物品陷入拖网中就有5%的几率产生呱肯乌贼。击杀呱肯乌贼的20天内不会再产生第二个呱肯乌贼。它本身没有近程攻击，但是会召唤呱肯乌贼的触手帮助它攻击(从小地图看就像是食人花和眼球草)，它的远程攻击是墨水弹，可以通过阴影躲避，被击中受到50点伤害，并且墨水弹掉落位置会形成持续几秒的墨水斑点，在墨水斑点区域内会减速70%。当本体每损失250点生命时，呱肯乌贼会移动到附近的另一个地方，总共会移动三次。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_quacken_tentacle_click(sender As Object, e As RoutedEventArgs) Handles button_A_quacken_tentacle.Click
        Dim LootHeight As Integer = A_Loot("G_tentacle_spike", "1(5%)", "G_tentacle_spots", "1(10%)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "制造巨浪")
        A_Show("呱肯乌贼的触手", "Quacken Tentacle", "A_quacken_tentacle", "SW", 0, 1, 0, 90, 0, 50, 6, 4, 0, 0, 3, 0, True, True, "呱肯乌贼的触手本身会近程攻击，另外还会掀起浪花攻击，生命值和呱肯乌贼本体并不共享，所以无视就好了。击杀后获得的铁制钥匙是和金制钥匙、骨制钥匙一起解锁火山笼子里的伍德莱格的。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_sealnado_click(sender As Object, e As RoutedEventArgs) Handles button_A_sealnado.Click
        Dim LootHeight As Integer = A_Loot("G_turbine_blades", "1")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "范围攻击", "可以在岛屿和海洋活动")
        A_Show("豹卷风", "Sealnado", "A_sealnado", "SW", 0, 1, 0, 3000, 0, 75, 3, 6, 5, 13, 9, 0, False, False, "豹卷风是船难版的BOSS之一，会在风季出现。平时不去惹它时不会主动攻击，但是当玩家靠的过近或者攻击它时它就会拍打一下然后吸入周围所有物品再喷出来，被吸入会减少250点生命并下降33点精神(目前版本有一个被吸入就无法出来的BUG，只能重启游戏了)。要击杀它用打二走一的方法或者用远程武器击杀，死后生成海豹。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_seal_click(sender As Object, e As RoutedEventArgs) Handles button_A_seal.Click
        Dim LootHeight As Integer = A_Loot("F_meat", "4", "G_magic_seal", "1(无论是否被击杀)")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight)
        A_Show("海豹", "Seal", "A_seal", "SW", 0, 1, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, False, False, "豹卷风死后生成无害的海豹，但是击杀它会立即引来坎普斯。不论是否击杀都能得到豹印。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_tiger_shark_click(sender As Object, e As RoutedEventArgs) Handles button_A_tiger_shark.Click
        Dim LootHeight As Integer = A_Loot("F_raw_fish", "8", "F_eye_of_the_tiger_shark", "1-2", "G_shark_gills", "2-4")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "范围攻击", "可以在陆地或海洋", "生成小虎鲨")
        A_Show("虎鲨", "Tiger Shark", "A_tiger_shark", "SW", 0, 1, 0, 2500, 0, 100, 3, 4, 8, 12, 7, 0, True, False, "虎鲨是船难版的BOSS之一，会在任何季节玩家做某些事情时在海岸边生成，风季的可能性比较大(用海洋陷阱和拖网的可能性也比较大)。它的攻击是范围性的。白天时，当它的血量低于250就会逃入海中，玩家无法追上，只能用远程武器击杀，黄昏和夜晚则不会逃跑，并且在陆地，可以轻松击杀。", LootHeight, SpecialAbilityHeight)
    End Sub

    Private Sub button_A_sharkitten_click(sender As Object, e As RoutedEventArgs) Handles button_A_sharkitten.Click
        Dim LootHeight As Integer = A_Loot("F_raw_fish", "2-3", "G_shark_gills", "0-2")
        Dim SpecialAbilityHeight As Integer = A_SpecialAbility(LootHeight, "被虎鲨保护")
        A_Show("小虎鲨", "Sharkitten", "A_sharkitten", "SW", 0, 1, 0, 150, 0, 0, 0, 0, 0, 0, 0, 0, False, False, "虎鲨生成的生物，不会攻击，只会跟随着虎鲨。", LootHeight, SpecialAbilityHeight)
    End Sub

    REM 生物DLC检测初始化
    Private Sub A_DLC_Check_initialization()
        REM 陆地生物
        button_A_rabbit.Visibility = Visibility.Collapsed
        button_A_rabbit_winter.Visibility = Visibility.Collapsed
        button_A_beardling.Visibility = Visibility.Collapsed
        button_A_gobbler.Visibility = Visibility.Collapsed
        button_A_frog.Visibility = Visibility.Collapsed
        button_A_catcoon.Visibility = Visibility.Collapsed
        button_A_moleworm.Visibility = Visibility.Collapsed
        button_A_spider_warrior.Visibility = Visibility.Collapsed
        button_A_pig_man.Visibility = Visibility.Collapsed
        button_A_guard_pig.Visibility = Visibility.Collapsed
        button_A_baby_beefalo.Visibility = Visibility.Collapsed
        button_A_toddler_beefalo.Visibility = Visibility.Collapsed
        button_A_teen_beefalo.Visibility = Visibility.Collapsed
        button_A_beefalo.Visibility = Visibility.Collapsed
        button_A_pengull.Visibility = Visibility.Collapsed
        button_A_wee_mactusk.Visibility = Visibility.Collapsed
        button_A_mactusk.Visibility = Visibility.Collapsed
        button_A_volt_goat.Visibility = Visibility.Collapsed
        button_A_volt_goat_withelectric.Visibility = Visibility.Collapsed
        button_A_koalefant.Visibility = Visibility.Collapsed
        button_A_winter_koalefant.Visibility = Visibility.Collapsed
        button_A_clockwork_knight.Visibility = Visibility.Collapsed
        button_A_clockwork_bishop.Visibility = Visibility.Collapsed
        button_A_clckwork_rook.Visibility = Visibility.Collapsed
        button_A_grass_gekko.Visibility = Visibility.Collapsed
        button_A_grass_gekko_disease.Visibility = Visibility.Collapsed
        button_A_crabbit.Visibility = Visibility.Collapsed
        button_A_beardling_sw.Visibility = Visibility.Collapsed
        button_A_prime_ape.Visibility = Visibility.Collapsed
        button_A_spider_warrior_sw.Visibility = Visibility.Collapsed
        button_A_fishermerm.Visibility = Visibility.Collapsed
        button_A_flup.Visibility = Visibility.Collapsed
        button_A_wildbore.Visibility = Visibility.Collapsed
        button_A_snake.Visibility = Visibility.Collapsed
        button_A_poison_snake.Visibility = Visibility.Collapsed
        button_A_baby_doydoy.Visibility = Visibility.Collapsed
        button_A_doydoy_child.Visibility = Visibility.Collapsed
        button_A_doydoy.Visibility = Visibility.Collapsed
        button_A_dragoon.Visibility = Visibility.Collapsed
        button_A_elephant_cactus.Visibility = Visibility.Collapsed
        REM 海洋生物
        TextBlock_A_Sea.Visibility = Visibility.Collapsed
        WrapPanel_A_sea.Visibility = Visibility.Collapsed
        REM 飞行生物
        button_A_butterfly.Visibility = Visibility.Collapsed
        button_A_butterfly_sw.Visibility = Visibility.Collapsed
        button_A_mosquito.Visibility = Visibility.Collapsed
        button_A_mosquito_sw.Visibility = Visibility.Collapsed
        button_A_redbird.Visibility = Visibility.Collapsed
        button_A_snowbird.Visibility = Visibility.Collapsed
        button_A_crow.Visibility = Visibility.Collapsed
        button_A_buzzards.Visibility = Visibility.Collapsed
        button_A_parrot.Visibility = Visibility.Collapsed
        button_A_parrot_pirate.Visibility = Visibility.Collapsed
        button_A_toucan.Visibility = Visibility.Collapsed
        button_A_seagull.Visibility = Visibility.Collapsed
        button_A_fireflies.Visibility = Visibility.Collapsed
        REM 洞穴生物
        TextBlock_A_Cave.Visibility = Visibility.Collapsed
        WrapPanel_A_cave.Visibility = Visibility.Collapsed
        button_A_bunnyman.Visibility = Visibility.Collapsed
        button_A_beardlord.Visibility = Visibility.Collapsed
        button_A_blue_spore.Visibility = Visibility.Collapsed
        button_A_green_spore.Visibility = Visibility.Collapsed
        button_A_red_spore.Visibility = Visibility.Collapsed
        button_A_splumonkey.Visibility = Visibility.Collapsed
        button_A_shadow_splumonkey.Visibility = Visibility.Collapsed
        button_A_cave_spider.Visibility = Visibility.Collapsed
        button_A_spitter.Visibility = Visibility.Collapsed
        button_A_dangling_depth_dweller.Visibility = Visibility.Collapsed
        button_A_batilisk.Visibility = Visibility.Collapsed
        button_A_slurtles.Visibility = Visibility.Collapsed
        button_A_snurtles.Visibility = Visibility.Collapsed
        button_A_rock_lobster.Visibility = Visibility.Collapsed
        button_A_slurper.Visibility = Visibility.Collapsed
        button_A_big_tentacle.Visibility = Visibility.Collapsed
        button_A_baby_tentacle.Visibility = Visibility.Collapsed
        button_A_damaged_knight.Visibility = Visibility.Collapsed
        button_A_damaged_bishop.Visibility = Visibility.Collapsed
        button_A_damage_rook.Visibility = Visibility.Collapsed
        REM 邪恶生物
        button_A_tentacle.Visibility = Visibility.Collapsed
        button_A_shadow_tentacle.Visibility = Visibility.Collapsed
        button_A_depths_worm.Visibility = Visibility.Collapsed
        button_A_sea_hound.Visibility = Visibility.Collapsed
        button_A_krampus.Visibility = Visibility.Collapsed
        button_A_krampus_sw.Visibility = Visibility.Collapsed
        button_A_ghost.Visibility = Visibility.Collapsed
        button_A_pirate_ghost.Visibility = Visibility.Collapsed
        button_A_mr_skits.Visibility = Visibility.Collapsed
        button_A_mr_skittish.Visibility = Visibility.Collapsed
        button_A_swimming_horror.Visibility = Visibility.Collapsed
        button_A_varg.Visibility = Visibility.Collapsed
        button_A_ewecus.Visibility = Visibility.Collapsed
        REM 其他生物
        button_A_glommer.Visibility = Visibility.Collapsed
        button_A_chester.Visibility = Visibility.Collapsed
        button_A_snow_chester.Visibility = Visibility.Collapsed
        button_A_shadow_chester.Visibility = Visibility.Collapsed
        button_A_hutch.Visibility = Visibility.Collapsed
        button_A_fugu_hutch.Visibility = Visibility.Collapsed
        button_A_music_box_hutch.Visibility = Visibility.Collapsed
        button_A_packim_baggims.Visibility = Visibility.Collapsed
        button_A_fat_packim_baggims.Visibility = Visibility.Collapsed
        button_A_fire_packim_baggims.Visibility = Visibility.Collapsed
        button_A_pig_king.Visibility = Visibility.Collapsed
        button_A_yaarctopus.Visibility = Visibility.Collapsed
        REM 巨型生物
        button_A_treeguard_1.Visibility = Visibility.Collapsed
        button_A_treeguard_2.Visibility = Visibility.Collapsed
        button_A_treeguard_3.Visibility = Visibility.Collapsed
        button_A_poison_birchnut_trees.Visibility = Visibility.Collapsed
        button_A_birchnutter.Visibility = Visibility.Collapsed
        button_A_palm_treeguard.Visibility = Visibility.Collapsed
        button_A_spider_queen.Visibility = Visibility.Collapsed
        button_A_big_tentacle.Visibility = Visibility.Collapsed
        button_A_baby_tentacle.Visibility = Visibility.Collapsed
        button_A_ancient_guardian.Visibility = Visibility.Collapsed
        button_A_moose.Visibility = Visibility.Collapsed
        button_A_mosling.Visibility = Visibility.Collapsed
        button_A_dragonfly.Visibility = Visibility.Collapsed
        button_A_lavae.Visibility = Visibility.Collapsed
        button_A_Extra_Adorable_Lavae.Visibility = Visibility.Collapsed
        button_A_bearger.Visibility = Visibility.Collapsed
        button_A_deerclops.Visibility = Visibility.Collapsed
        button_A_quacken.Visibility = Visibility.Collapsed
        button_A_quacken_tentacle.Visibility = Visibility.Collapsed
        button_A_sealnado.Visibility = Visibility.Collapsed
        button_A_seal.Visibility = Visibility.Collapsed
        button_A_tiger_shark.Visibility = Visibility.Collapsed
        button_A_sharkitten.Visibility = Visibility.Collapsed
    End Sub

    Private Sub A_DLC_ROG_SHOW()
        REM 陆地生物
        button_A_rabbit.Visibility = Visibility.Visible
        button_A_rabbit_winter.Visibility = Visibility.Visible
        button_A_beardling.Visibility = Visibility.Visible
        button_A_gobbler.Visibility = Visibility.Visible
        button_A_frog.Visibility = Visibility.Visible
        button_A_catcoon.Visibility = Visibility.Visible
        button_A_moleworm.Visibility = Visibility.Visible
        button_A_spider_warrior.Visibility = Visibility.Visible
        button_A_pig_man.Visibility = Visibility.Visible
        button_A_guard_pig.Visibility = Visibility.Visible
        button_A_baby_beefalo.Visibility = Visibility.Visible
        button_A_toddler_beefalo.Visibility = Visibility.Visible
        button_A_teen_beefalo.Visibility = Visibility.Visible
        button_A_beefalo.Visibility = Visibility.Visible
        button_A_pengull.Visibility = Visibility.Visible
        button_A_wee_mactusk.Visibility = Visibility.Visible
        button_A_mactusk.Visibility = Visibility.Visible
        button_A_volt_goat.Visibility = Visibility.Visible
        button_A_volt_goat_withelectric.Visibility = Visibility.Visible
        button_A_koalefant.Visibility = Visibility.Visible
        button_A_winter_koalefant.Visibility = Visibility.Visible
        button_A_clockwork_knight.Visibility = Visibility.Visible
        button_A_clockwork_bishop.Visibility = Visibility.Visible
        button_A_clckwork_rook.Visibility = Visibility.Visible
        REM 海洋生物
        REM 飞行生物
        button_A_butterfly.Visibility = Visibility.Visible
        button_A_mosquito.Visibility = Visibility.Visible
        button_A_redbird.Visibility = Visibility.Visible
        button_A_snowbird.Visibility = Visibility.Visible
        button_A_crow.Visibility = Visibility.Visible
        button_A_buzzards.Visibility = Visibility.Visible
        button_A_fireflies.Visibility = Visibility.Visible
        REM 洞穴生物
        TextBlock_A_Cave.Visibility = Visibility.Visible
        WrapPanel_A_cave.Visibility = Visibility.Visible
        button_A_bunnyman.Visibility = Visibility.Visible
        button_A_beardlord.Visibility = Visibility.Visible
        button_A_splumonkey.Visibility = Visibility.Visible
        button_A_shadow_splumonkey.Visibility = Visibility.Visible
        button_A_cave_spider.Visibility = Visibility.Visible
        button_A_spitter.Visibility = Visibility.Visible
        button_A_dangling_depth_dweller.Visibility = Visibility.Visible
        button_A_batilisk.Visibility = Visibility.Visible
        button_A_slurtles.Visibility = Visibility.Visible
        button_A_snurtles.Visibility = Visibility.Visible
        button_A_rock_lobster.Visibility = Visibility.Visible
        button_A_slurper.Visibility = Visibility.Visible
        button_A_big_tentacle.Visibility = Visibility.Visible
        button_A_baby_tentacle.Visibility = Visibility.Visible
        button_A_damaged_knight.Visibility = Visibility.Visible
        button_A_damaged_bishop.Visibility = Visibility.Visible
        button_A_damage_rook.Visibility = Visibility.Visible
        REM 邪恶生物
        button_A_tentacle.Visibility = Visibility.Visible
        button_A_shadow_tentacle.Visibility = Visibility.Visible
        button_A_depths_worm.Visibility = Visibility.Visible
        button_A_krampus.Visibility = Visibility.Visible
        button_A_ghost.Visibility = Visibility.Visible
        button_A_mr_skits.Visibility = Visibility.Visible
        button_A_varg.Visibility = Visibility.Visible
        REM 其他生物
        button_A_glommer.Visibility = Visibility.Visible
        button_A_chester.Visibility = Visibility.Visible
        button_A_snow_chester.Visibility = Visibility.Visible
        button_A_shadow_chester.Visibility = Visibility.Visible
        button_A_pig_king.Visibility = Visibility.Visible
        REM 巨型生物
        button_A_treeguard_1.Visibility = Visibility.Visible
        button_A_treeguard_2.Visibility = Visibility.Visible
        button_A_treeguard_3.Visibility = Visibility.Visible
        button_A_poison_birchnut_trees.Visibility = Visibility.Visible
        button_A_birchnutter.Visibility = Visibility.Visible
        button_A_spider_queen.Visibility = Visibility.Visible
        button_A_big_tentacle.Visibility = Visibility.Visible
        button_A_baby_tentacle.Visibility = Visibility.Visible
        button_A_ancient_guardian.Visibility = Visibility.Visible
        button_A_moose.Visibility = Visibility.Visible
        button_A_mosling.Visibility = Visibility.Visible
        button_A_dragonfly.Visibility = Visibility.Visible
        button_A_lavae.Visibility = Visibility.Visible
        button_A_Extra_Adorable_Lavae.Visibility = Visibility.Visible
        button_A_bearger.Visibility = Visibility.Visible
        button_A_deerclops.Visibility = Visibility.Visible
    End Sub

    Private Sub A_DLC_SW_SHOW()
        REM 陆地生物
        button_A_crabbit.Visibility = Visibility.Visible
        button_A_beardling_sw.Visibility = Visibility.Visible
        button_A_prime_ape.Visibility = Visibility.Visible
        button_A_spider_warrior_sw.Visibility = Visibility.Visible
        button_A_fishermerm.Visibility = Visibility.Visible
        button_A_flup.Visibility = Visibility.Visible
        button_A_wildbore.Visibility = Visibility.Visible
        button_A_snake.Visibility = Visibility.Visible
        button_A_poison_snake.Visibility = Visibility.Visible
        button_A_baby_doydoy.Visibility = Visibility.Visible
        button_A_doydoy_child.Visibility = Visibility.Visible
        button_A_doydoy.Visibility = Visibility.Visible
        button_A_dragoon.Visibility = Visibility.Visible
        button_A_elephant_cactus.Visibility = Visibility.Visible
        REM 海洋生物
        TextBlock_A_Sea.Visibility = Visibility.Visible
        WrapPanel_A_sea.Visibility = Visibility.Visible
        REM 飞行生物
        button_A_butterfly_sw.Visibility = Visibility.Visible
        button_A_mosquito_sw.Visibility = Visibility.Visible
        button_A_parrot.Visibility = Visibility.Visible
        button_A_parrot_pirate.Visibility = Visibility.Visible
        button_A_toucan.Visibility = Visibility.Visible
        button_A_seagull.Visibility = Visibility.Visible
        REM 洞穴生物
        REM 邪恶生物
        button_A_sea_hound.Visibility = Visibility.Visible
        button_A_krampus_sw.Visibility = Visibility.Visible
        button_A_pirate_ghost.Visibility = Visibility.Visible
        button_A_mr_skittish.Visibility = Visibility.Visible
        button_A_swimming_horror.Visibility = Visibility.Visible
        REM 其他生物
        button_A_packim_baggims.Visibility = Visibility.Visible
        button_A_fat_packim_baggims.Visibility = Visibility.Visible
        button_A_fire_packim_baggims.Visibility = Visibility.Visible
        button_A_yaarctopus.Visibility = Visibility.Visible
        REM 巨型生物
        button_A_palm_treeguard.Visibility = Visibility.Visible
        button_A_quacken.Visibility = Visibility.Visible
        button_A_quacken_tentacle.Visibility = Visibility.Visible
        button_A_sealnado.Visibility = Visibility.Visible
        button_A_seal.Visibility = Visibility.Visible
        button_A_tiger_shark.Visibility = Visibility.Visible
        button_A_sharkitten.Visibility = Visibility.Visible
    End Sub

    Private Sub A_DLC_DST_SHOW()
        REM 陆地生物
        button_A_rabbit.Visibility = Visibility.Visible
        button_A_rabbit_winter.Visibility = Visibility.Visible
        button_A_beardling.Visibility = Visibility.Visible
        button_A_gobbler.Visibility = Visibility.Visible
        button_A_frog.Visibility = Visibility.Visible
        button_A_catcoon.Visibility = Visibility.Visible
        button_A_moleworm.Visibility = Visibility.Visible
        button_A_spider_warrior.Visibility = Visibility.Visible
        button_A_pig_man.Visibility = Visibility.Visible
        button_A_guard_pig.Visibility = Visibility.Visible
        button_A_baby_beefalo.Visibility = Visibility.Visible
        button_A_toddler_beefalo.Visibility = Visibility.Visible
        button_A_teen_beefalo.Visibility = Visibility.Visible
        button_A_beefalo.Visibility = Visibility.Visible
        button_A_pengull.Visibility = Visibility.Visible
        button_A_wee_mactusk.Visibility = Visibility.Visible
        button_A_mactusk.Visibility = Visibility.Visible
        button_A_volt_goat.Visibility = Visibility.Visible
        button_A_volt_goat_withelectric.Visibility = Visibility.Visible
        button_A_koalefant.Visibility = Visibility.Visible
        button_A_winter_koalefant.Visibility = Visibility.Visible
        button_A_clockwork_knight.Visibility = Visibility.Visible
        button_A_clockwork_bishop.Visibility = Visibility.Visible
        button_A_clckwork_rook.Visibility = Visibility.Visible
        button_A_grass_gekko.Visibility = Visibility.Visible
        button_A_grass_gekko_disease.Visibility = Visibility.Visible
        REM 海洋生物
        REM 飞行生物
        button_A_butterfly.Visibility = Visibility.Visible
        button_A_mosquito.Visibility = Visibility.Visible
        button_A_redbird.Visibility = Visibility.Visible
        button_A_snowbird.Visibility = Visibility.Visible
        button_A_crow.Visibility = Visibility.Visible
        button_A_buzzards.Visibility = Visibility.Visible
        button_A_fireflies.Visibility = Visibility.Visible
        REM 洞穴生物
        TextBlock_A_Cave.Visibility = Visibility.Visible
        WrapPanel_A_cave.Visibility = Visibility.Visible
        button_A_bunnyman.Visibility = Visibility.Visible
        button_A_beardlord.Visibility = Visibility.Visible
        button_A_blue_spore.Visibility = Visibility.Visible
        button_A_green_spore.Visibility = Visibility.Visible
        button_A_red_spore.Visibility = Visibility.Visible
        button_A_splumonkey.Visibility = Visibility.Visible
        button_A_shadow_splumonkey.Visibility = Visibility.Visible
        button_A_cave_spider.Visibility = Visibility.Visible
        button_A_spitter.Visibility = Visibility.Visible
        button_A_dangling_depth_dweller.Visibility = Visibility.Visible
        button_A_batilisk.Visibility = Visibility.Visible
        button_A_slurtles.Visibility = Visibility.Visible
        button_A_snurtles.Visibility = Visibility.Visible
        button_A_rock_lobster.Visibility = Visibility.Visible
        button_A_slurper.Visibility = Visibility.Visible
        button_A_big_tentacle.Visibility = Visibility.Visible
        button_A_baby_tentacle.Visibility = Visibility.Visible
        button_A_damaged_knight.Visibility = Visibility.Visible
        button_A_damaged_bishop.Visibility = Visibility.Visible
        button_A_damage_rook.Visibility = Visibility.Visible
        REM 邪恶生物
        button_A_tentacle.Visibility = Visibility.Visible
        button_A_shadow_tentacle.Visibility = Visibility.Visible
        button_A_depths_worm.Visibility = Visibility.Visible
        button_A_krampus.Visibility = Visibility.Visible
        button_A_ghost.Visibility = Visibility.Visible
        button_A_mr_skits.Visibility = Visibility.Visible
        button_A_varg.Visibility = Visibility.Visible
        button_A_ewecus.Visibility = Visibility.Visible
        REM 其他生物
        button_A_glommer.Visibility = Visibility.Visible
        button_A_chester.Visibility = Visibility.Visible
        button_A_snow_chester.Visibility = Visibility.Visible
        button_A_shadow_chester.Visibility = Visibility.Visible
        button_A_hutch.Visibility = Visibility.Visible
        button_A_fugu_hutch.Visibility = Visibility.Visible
        button_A_music_box_hutch.Visibility = Visibility.Visible
        button_A_pig_king.Visibility = Visibility.Visible
        REM 巨型生物
        button_A_treeguard_1.Visibility = Visibility.Visible
        button_A_treeguard_2.Visibility = Visibility.Visible
        button_A_treeguard_3.Visibility = Visibility.Visible
        button_A_poison_birchnut_trees.Visibility = Visibility.Visible
        button_A_birchnutter.Visibility = Visibility.Visible
        button_A_spider_queen.Visibility = Visibility.Visible
        button_A_big_tentacle.Visibility = Visibility.Visible
        button_A_baby_tentacle.Visibility = Visibility.Visible
        button_A_ancient_guardian.Visibility = Visibility.Visible
        button_A_moose.Visibility = Visibility.Visible
        button_A_mosling.Visibility = Visibility.Visible
        button_A_dragonfly.Visibility = Visibility.Visible
        button_A_lavae.Visibility = Visibility.Visible
        button_A_Extra_Adorable_Lavae.Visibility = Visibility.Visible
        button_A_bearger.Visibility = Visibility.Visible
        button_A_deerclops.Visibility = Visibility.Visible
    End Sub

    REM 生物DLC检测
    Private Sub A_DLC_Check()

        Dim A_ROG_SW_DST As SByte
        Dim A_ROG__ As SByte
        Dim A_SW__ As SByte
        Dim A_DST__ As SByte
        If checkBox_A_DLC_ROG.IsChecked = True Then
            A_ROG__ = 1
        Else
            A_ROG__ = 0
        End If
        If checkBox_A_DLC_SW.IsChecked = True Then
            A_SW__ = 2
        Else
            A_SW__ = 0
        End If
        If checkBox_A_DLC_DST.IsChecked = True Then
            A_DST__ = 4
        Else
            A_DST__ = 0
        End If
        A_ROG_SW_DST = A_ROG__ + A_SW__ + A_DST__
        If A_ROG_SW_DST = 0 Then
            MsgBox("至少选择一项！")
            checkBox_A_DLC_ROG.IsChecked = True
            A_DLC_Check()
        Else
            A_DLC_Check_initialization()
            Select Case A_ROG_SW_DST
                Case 1
                    A_DLC_ROG_SHOW()
                    WrapPanel_A_terrestrial.Height = 550
                    WrapPanel_A_fly.Height = 220
                    WrapPanel_A_cave.Height = 330
                    WrapPanel_A_evil.Height = 330
                    WrapPanel_A_other.Height = 110
                    WrapPanel_A_megafauna.Height = 330
                    WrapPanel_Animal.Height = 2870 - 7 * 110 - 25.4
                    Reg_Write("Animal", 1)
                Case 2
                    A_DLC_SW_SHOW()
                    WrapPanel_A_terrestrial.Height = 330
                    WrapPanel_A_sea.Height = 220
                    WrapPanel_A_fly.Height = 220
                    WrapPanel_A_evil.Height = 220
                    WrapPanel_A_other.Height = 110
                    WrapPanel_A_megafauna.Height = 110
                    WrapPanel_Animal.Height = 2870 - 12 * 110 - 25.4
                    Reg_Write("Animal", 2)
                Case 3
                    A_DLC_ROG_SHOW()
                    A_DLC_SW_SHOW()
                    WrapPanel_A_terrestrial.Height = 770
                    WrapPanel_A_sea.Height = 220
                    WrapPanel_A_fly.Height = 330
                    WrapPanel_A_cave.Height = 330
                    WrapPanel_A_evil.Height = 330
                    WrapPanel_A_other.Height = 220
                    WrapPanel_A_megafauna.Height = 330
                    WrapPanel_Animal.Height = 2870
                    Reg_Write("Animal", 3)
                Case 4
                    A_DLC_DST_SHOW()
                    WrapPanel_A_terrestrial.Height = 550
                    WrapPanel_A_fly.Height = 220
                    WrapPanel_A_cave.Height = 330
                    WrapPanel_A_evil.Height = 330
                    WrapPanel_A_other.Height = 220
                    WrapPanel_A_megafauna.Height = 330
                    WrapPanel_Animal.Height = 2870 - 6 * 110 - 25.4
                    Reg_Write("Animal", 4)
                Case 5
                    A_DLC_ROG_SHOW()
                    A_DLC_DST_SHOW()
                    WrapPanel_A_terrestrial.Height = 550
                    WrapPanel_A_fly.Height = 220
                    WrapPanel_A_cave.Height = 330
                    WrapPanel_A_evil.Height = 330
                    WrapPanel_A_other.Height = 220
                    WrapPanel_A_megafauna.Height = 330
                    WrapPanel_Animal.Height = 2870 - 6 * 110 - 25.4
                    Reg_Write("Animal", 5)
                Case 6
                    A_DLC_SW_SHOW()
                    A_DLC_DST_SHOW()
                    WrapPanel_A_terrestrial.Height = 770
                    WrapPanel_A_sea.Height = 220
                    WrapPanel_A_fly.Height = 330
                    WrapPanel_A_cave.Height = 330
                    WrapPanel_A_evil.Height = 330
                    WrapPanel_A_other.Height = 220
                    WrapPanel_A_megafauna.Height = 330
                    WrapPanel_Animal.Height = 2870
                    Reg_Write("Animal", 6)
                Case 7
                    A_DLC_ROG_SHOW()
                    A_DLC_SW_SHOW()
                    A_DLC_DST_SHOW()
                    WrapPanel_A_terrestrial.Height = 770
                    WrapPanel_A_sea.Height = 220
                    WrapPanel_A_fly.Height = 330
                    WrapPanel_A_cave.Height = 330
                    WrapPanel_A_evil.Height = 330
                    WrapPanel_A_other.Height = 220
                    WrapPanel_A_megafauna.Height = 330
                    WrapPanel_Animal.Height = 2870
                    Reg_Write("Animal", 7)
            End Select
        End If
    End Sub

    Private Sub checkBox_A_DLC_ROG_click(sender As Object, e As RoutedEventArgs) Handles checkBox_A_DLC_ROG.Click
        A_DLC_Check()
    End Sub

    Private Sub SL_button_A_DLC_ROG_click(sender As Object, e As RoutedEventArgs) Handles SL_button_A_DLC_ROG.Click
        If checkBox_A_DLC_ROG.IsChecked = True Then
            checkBox_A_DLC_ROG.IsChecked = False
        Else
            checkBox_A_DLC_ROG.IsChecked = True
        End If
        checkBox_A_DLC_ROG_click(Nothing, Nothing)
    End Sub

    Private Sub checkBox_A_DLC_SW_click(sender As Object, e As RoutedEventArgs) Handles checkBox_A_DLC_SW.Click
        A_DLC_Check()
    End Sub

    Private Sub SL_button_A_DLC_SW_click(sender As Object, e As RoutedEventArgs) Handles SL_button_A_DLC_SW.Click
        If checkBox_A_DLC_SW.IsChecked = True Then
            checkBox_A_DLC_SW.IsChecked = False
        Else
            checkBox_A_DLC_SW.IsChecked = True
        End If
        checkBox_A_DLC_SW_click(Nothing, Nothing)
    End Sub

    Private Sub checkBox_A_DLC_DST_click(sender As Object, e As RoutedEventArgs) Handles checkBox_A_DLC_DST.Click
        A_DLC_Check()
    End Sub

    Private Sub SL_button_A_DLC_DST_click(sender As Object, e As RoutedEventArgs) Handles SL_button_A_DLC_DST.Click
        If checkBox_A_DLC_DST.IsChecked = True Then
            checkBox_A_DLC_DST.IsChecked = False
        Else
            checkBox_A_DLC_DST.IsChecked = True
        End If
        checkBox_A_DLC_DST_click(Nothing, Nothing)
    End Sub
#End Region

#Region "自然"


#Region "自然_生物群落"

    Private Sub button_N_beach_click(sender As Object, e As RoutedEventArgs) Handles button_N_beach.Click
        NB_Abundant({"N_palm_tree_1", "N_sapling", "N_grass_sw", "G_flint", "N_crabbit_den", "N_sandy_pile", "G_seashell"})
        NB_Occasional({"G_rocky_turf", "N_boulder_1", "N_boulder_3", "N_limpet_rock", "N_wildbore_house"})
        NB_Rare({"N_crate_1"})
        N_Show_B("海滩", "Beach", "N_beach", "NoDLC", 0, 1, 0, "海滩是船难版常见的生物群落之一，它们一般有多种类型的资源。玩家进入世界(船难版)总会出生在海滩。晚上临近海洋的区域会被淹没，月圆之夜是潮汐最强的时候。")
    End Sub

    Private Sub button_N_jungle_click(sender As Object, e As RoutedEventArgs) Handles button_N_jungle.Click
        NB_Abundant({"N_jungle_tree_1", "N_bamboo_patch", "N_viney_bush", "N_flower_1", "A_fireflies", "N_prime_ape_hut", "A_spider"})
        NB_Occasional({"N_berry_bush_2", "N_boulder_2", "N_wildbore_house", "N_spider_den", "N_blue_mushroom", "N_green_mushroom", "N_red_mushroom", "A_snake", "A_poison_snake", "A_butterfly"})
        NB_Rare({"N_boulder_1", "G_rocks", "G_flint"})
        N_Show_B("热带雨林", "Jungle", "N_jungle", "NoDLC", 0, 1, 0, "热带雨林生物群落的生物、植物和资源都十分丰富，在这里要小心蛇和猿猴，它们十分令人讨厌。")
    End Sub

    Private Sub button_N_mangrove_bio_click(sender As Object, e As RoutedEventArgs) Handles button_N_mangrove_bio.Click
        NB_Abundant({"N_mangrove_1", "N_grass_sw"})
        NB_Occasional({"N_shoal"})
        NB_Rare({"A_water_beefalo"})
        N_Show_B("红树林", "Mangrove", "N_mangrove_bio", "NoDLC", 0, 1, 0, "这里虽然只能乘船通行，然而一般还是认为是一个岛屿，这里生活着水牛，草不会枯萎。")
    End Sub

    Private Sub button_N_magma_field_click(sender As Object, e As RoutedEventArgs) Handles button_N_magma_field.Click
        NB_Abundant({"N_magma_pile", "N_magma_pile_gold", "N_krissure"})
        NB_Occasional({"N_sapling", "N_boulder_1", "N_boulder_2"})
        NB_Rare({"A_tallbird", "N_tallbird_nest"})
        N_Show_B("岩浆领域", "Magma Field", "N_magma_field", "NoDLC", 0, 1, 0, "黑暗而崎岖的地形，有丰富的熔岩矿和熔岩金矿，偶尔会遇到高脚鸟。要小心压力火泉。")
    End Sub

    Private Sub button_N_meadow_click(sender As Object, e As RoutedEventArgs) Handles button_N_meadow.Click
        NB_Abundant({"N_grass_sw", "N_flower_1", "A_butterfly", "F_sweet_potato"})
        NB_Occasional({"G_rocks", "G_flint", "N_beehive", "A_mandrake"})
        NB_Rare({"N_red_mushroom"})
        N_Show_B("草甸", "Meadow", "N_meadow", "NoDLC", 0, 1, 0, "富含草的生物群落，这里也是唯一能找到甘薯的地方，通常还有少量的蜂巢和曼德拉草。")
    End Sub

    Private Sub button_N_tidal_marsh_click(sender As Object, e As RoutedEventArgs) Handles button_N_tidal_marsh.Click
        NB_Abundant({"N_reeds", "A_flup", "N_tidal_pool", "N_poisonous_hole"})
        NB_Occasional({"A_merm", "N_merm_hut"})
        NB_Rare({"A_fishermerm", "N_fishermerm's_hut"})
        N_Show_B("潮汐沼泽", "Tidal Marsh", "N_tidal_marsh", "NoDLC", 0, 1, 0, "潮汐沼泽通常存在于单独的小岛，覆盖满了潮滩地皮。这里是鱼人/渔人和追踪性弹涂鱼的天堂，要小心毒洞哦！")
    End Sub

    Private Sub button_N_coral_reef_bio_click(sender As Object, e As RoutedEventArgs) Handles button_N_coral_reef_bio.Click
        NB_Abundant({"N_coral_reef", "N_shoal", "A_dogfish"})
        NB_Occasional({"N_seaweed", "A_jellyfish"})
        NB_Rare({"N_brainy_sprout"})
        N_Show_B("珊瑚礁", "Coral Reef", "N_coral_reef_bio", "NoDLC", 0, 1, 0, "珊瑚礁生物群落富含珊瑚礁，能找到浅滩和狗鱼，偶尔会有海藻和水母。运气好可以找到聪明芽。")
    End Sub

    Private Sub button_N_ocean_shallow_click(sender As Object, e As RoutedEventArgs) Handles button_N_ocean_shallow.Click
        NB_Abundant({"N_seaweed"})
        NB_Occasional({"A_jellyfish", "N_wobster_den", "F_mussel", "A_dogfish"})
        NB_Rare({"G_message_in_a_bottle"})
        N_Show_B("海洋(浅)", "Ocean(shallow)", "N_ocean_shallow", "NoDLC", 0, 1, 0, "淡蓝色的地形，没有海浪，围绕着所有岛屿，但是有可能会延伸。在这里可以发现贻贝、龙虾的巢穴、狗鱼和海藻。")
    End Sub

    Private Sub button_N_ocean_medium_click(sender As Object, e As RoutedEventArgs) Handles button_N_ocean_medium.Click
        NB_Abundant({"N_waves"})
        NB_Occasional({"A_stink_ray", "A_seagull"})
        NB_Rare({"A_dogfish", "N_shoal"})
        N_Show_B("海洋(中)", "Ocean(medium)", "N_ocean_medium", "NoDLC", 0, 1, 0, "这里有许多的海浪，在这里可以发现恶臭魔鬼鱼、可疑的气泡、浅滩、旗鱼，温和季节会有海鸥出现。不会与岛屿接壤。")
    End Sub

    Private Sub button_N_ocean_deep_click(sender As Object, e As RoutedEventArgs) Handles button_N_ocean_deep.Click
        NB_Abundant({"N_waves"})
        NB_Occasional({"A_bottenosed_ballphin", "A_seagull"})
        NB_Rare({"A_swordfish", "N_shoal", "G_rawling", "N_volcano"})
        N_Show_B("海洋(深)", "Ocean(deep)", "N_ocean_deep", "NoDLC", 0, 1, 0, "海洋深处，深色区域，只有这里有残骸和潮湿的坟墓，通常可以找到浅滩、海藻和狗鱼。不会与海洋(浅)和岛屿接壤。")
    End Sub

    Private Sub button_N_ship_graveyard_click(sender As Object, e As RoutedEventArgs) Handles button_N_ship_graveyard.Click
        NB_Abundant({})
        NB_Occasional({"N_wreck_1", "N_steamer_trunk", "N_shoal"})
        NB_Rare({"N_seaweed", "N_watery_grave_1", "A_swordfish"})
        N_Show_B("船舶墓地", "Ship Graveyard", "N_ship_graveyard", "NoDLC", 0, 1, 0, "残骸和潮湿的坟墓区域。")
    End Sub

    Private Sub button_N_volcano_bio_click(sender As Object, e As RoutedEventArgs) Handles button_N_volcano_bio.Click
        NB_Abundant({"N_coffee_plant", "N_magma_pile", "N_magma_pile_gold", "N_charcoal_boulder", "N_obsidian_boulder"})
        NB_Occasional({"N_skeleton_1", "N_elephant_cactus", "N_krissure", "N_dragoon_den"})
        NB_Rare({"N_obsidian_workbench", "N_woodlegs'_cage"})
        N_Show_B("火山", "Volcano", "N_volcano_bio", "NoDLC", 0, 1, 0, "围绕火山口的生物群落，中间是含有大量熔岩的区域，靠近会过热。在这里可以找到大量咖啡树、熔岩矿熔岩金矿、黑曜岩和煤矿，也有不少象仙人掌和龙人巢，必定有一个火山祭坛和黑曜石工作台。如果没有解锁伍德莱格那么在这里会发现伍德莱格的笼子。")
    End Sub
#End Region

#Region "自然_小型植物/树"

    Private Sub button_N_flower_click(sender As Object, e As RoutedEventArgs) Handles button_N_flower.Click
        NP_Picture("N_flower_", 11)
        NP_Resources(11, {"G_petals", "×1", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("花", "Flower", "NoDLC", 1, 1, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "N_forest", "生成", "A_butterfly", "拾取时精神+5", "", "花的用途多种多样。采集12朵花可以做花环，每次采集花都会增加5点精神，这在游戏前期十分有用。花还是产生蝴蝶的地方，捕捉的蝴蝶可以右键种植成花，这使得花可以重生。无家可归的蜜蜂也可以随着时间的推移产生新的花。许多花种在一起建立一个蝴蝶农场用以获取蝴蝶翅膀，也可以用来增加蜂蜜的产蜜速度。", True, True)
    End Sub

    Private Sub button_N_evil_flower_click(sender As Object, e As RoutedEventArgs) Handles button_N_evil_flower.Click
        NP_Picture("N_evil_flower_", 8)
        NP_Resources(11, {"G_dark_petals", "×1", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("恶魔之花", "Evil Flower", "NoDLC", 1, 1, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_chess", "N_forest", "生成", "A_butterfly", "拾取时精神-5", "", "恶魔之花通常存在于传送机零件、完全正常的树和麦斯威尔之门附近。拾取恶魔之花会减少5点精神。恶魔之花同样可以产生蝴蝶，并且吸引蝴蝶与蜜蜂。", True, True)
    End Sub

    Private Sub button_N_sapling_click(sender As Object, e As RoutedEventArgs) Handles button_N_sapling.Click
        NP_Picture({"N_sapling", "N_sapling_empty"})
        ReDim NP_ResourcesArray(1, 11)
        NP_Resources(0, 0, {"G_twigs", "×1", "G_sapling", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 1, {"G_sapling", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("树苗", "Sapling", "NoDLC", 1, 1, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "N_forest", "", "", "", "", "树苗常见于草原和森林，它可以提供一个树枝。树苗可以移植，但是不能种植在方格地板、木质地板、卵石路、地毯地板、岩石草皮、沙地、洞穴石地上。不像草和浆果灌木丛，它不需要施肥，生长需要4天时间(冬天不会生长)。尽管叫树苗，但是永远不会长成树。在夏天树苗会枯萎，需要施肥或者在旁边建造雪球发射器防止这一情况的发生。在联机版里，开局两个季节之后树苗会患病，并且无法治愈。", False, True)
    End Sub

    Private Sub button_N_grass_click(sender As Object, e As RoutedEventArgs) Handles button_N_grass.Click
        NP_Picture({"N_grass", "N_grass_empty", "N_grass_dead"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"G_cut_grass", "×1", "G_grass_tuft", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 2, {"G_grass_tuft", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("草", "Grass", "NoDLC", 1, 1, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "N_savanna", "", "", "", "", "草常见于稀树大草原和森林，洞穴里也有一些，特别是在沉没森林区域，它可以提供一个割下的草。草可以移植，但是不能种植在方格地板、木质地板、卵石路、地毯地板、岩石草皮、沙地、洞穴石地上。移植的草需要施肥(便便、鸟屎、便便篮)，生长需要3天时间(下雨会减少生长时间，冬天生长得很慢)。在夏天草会枯萎，需要施肥或者在旁边建造雪球发射器防止这一情况的发生。在联机版里，开局两个季节之后草会患病，并且无法治愈。", False, True)
    End Sub

    Private Sub button_N_berry_bush_click(sender As Object, e As RoutedEventArgs) Handles button_N_berry_bush.Click
        NP_Picture({"N_berry_bush_1", "N_berry_bush_empty_1", "N_berry_bush_dead_1"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"F_berries", "×1", "G_berry_bush", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 1, {"G_berry_bush", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        NP_Resources(2, 2, {"G_twigs", "×2(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("浆果灌木丛", "Berry Bush", "NoDLC", 1, 0, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "N_forest", "生成", "A_gobbler", "", "", "浆果灌木丛常见于草原，偶尔在森林里也可以发现它们，它可以提供一个浆果。浆果灌木丛可以移植，但是不能种植在方格地板、木质地板、卵石路、地毯地板、岩石草皮、沙地、洞穴石地上。移植的浆果灌木丛需要施肥(便便、鸟屎、便便篮)，生长需要3-5天时间(下雨会减少生长时间，冬天不会生长)。采摘浆果的时候会出现火鸡，如果不击杀或驱逐它，它就会把周围可以收获的浆果全部吃光！在夏天浆果灌木丛会枯萎，需要施肥或者在旁边建造雪球发射器防止这一情况的发生。在联机版里，开局两个季节之后浆果灌木丛会患病，并且无法治愈。", False, True)
    End Sub

    Private Sub button_N_berry_bush_2_click(sender As Object, e As RoutedEventArgs) Handles button_N_berry_bush_2.Click
        NP_Picture({"N_berry_bush_2", "N_berry_bush_empty_2", "N_berry_bush_dead_2"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"F_berries", "×1", "G_berry_bush_2", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 1, {"G_berry_bush_2", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        NP_Resources(2, 2, {"G_twigs", "×2(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("浆果灌木丛", "Berry Bush", "NoDLC", 1, 1, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "", "生成", "A_gobbler", "生成              (SW)", "A_snake", "浆果灌木丛常见于草原，特别是猪村附近，它可以提供一个浆果。浆果灌木丛可以移植，但是不能种植在方格地板、木质地板、卵石路、地毯地板、岩石草皮、沙地、洞穴石地上。移植的浆果灌木丛需要施肥(便便、鸟屎、便便篮)，生长需要3-5天时间(下雨会减少生长时间，冬天不会生长)。采摘浆果的时候会出现火鸡，如果不击杀或驱逐它，它就会把周围可以收获的浆果全部吃光！在夏天浆果灌木丛会枯萎，需要施肥或者在旁边建造雪球发射器防止这一情况的发生。在联机版里，开局两个季节之后浆果灌木丛会患病，并且无法治愈。注意！这种浆果灌木丛不能制作丛林帽！", False, True)
    End Sub

    Private Sub button_N_juicy_berry_bush_click(sender As Object, e As RoutedEventArgs) Handles button_N_juicy_berry_bush.Click
        NP_Picture({"N_juicy_berry_bush", "N_juicy_berry_bush_empty", "N_juicy_berry_bush_dead"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"F_juicy_berries", "×3", "G_juicy_berry_bush", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 1, {"G_juicy_berry_bush", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        NP_Resources(2, 2, {"G_twigs", "×2(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("蜜汁浆果丛", "Juicy Berry Bush", "DST", 0, 0, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "N_forest", "", "", "", "", "蜜汁浆果丛是联机版中浆果灌木丛的一个变种，常见于草原，偶尔在森林里也可以发现它们，它可以提供三个蜜汁浆果。蜜汁浆果丛可以移植，但是不能种植在方格地板、木质地板、卵石路、地毯地板、岩石草皮、沙地、洞穴石地上。移植的蜜汁浆果丛需要施肥(便便、鸟屎、便便篮)，生长需要比浆果灌木丛更长的时间(下雨会减少生长时间，冬天不会生长)。蜜汁浆果丛会患病，并且无法治愈。", False, True)
    End Sub

    Private Sub button_N_reeds_click(sender As Object, e As RoutedEventArgs) Handles button_N_reeds.Click
        NP_Picture({"N_reeds", "N_reeds_empty"})
        ReDim NP_ResourcesArray(1, 11)
        NP_Resources(0, 0, {"G_cut_reeds", "×1", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("芦苇", "Reeds", "NoDLC", 1, 1, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_marsh", "", "", "", "", "", "芦苇常见于沼泽，它可以提供一个割好的芦苇。芦苇不能移植。生长需要3天时间(冬天不会生长)。有一种芦苇陷阱：沼泽地里一大片芦苇，并且伴随着一大片的触手，十分危险。", False, True)
    End Sub

    Private Sub button_N_spiky_bush_click(sender As Object, e As RoutedEventArgs) Handles button_N_spiky_bush.Click
        NP_Picture({"N_spiky_bush", "N_spiky_bush_empty"})
        ReDim NP_ResourcesArray(1, 11)
        NP_Resources(0, 0, {"G_twigs", "×1", "G_spiky_bushes", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 1, {"G_spiky_bushes", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("尖刺灌木", "Spiky Bush", "NoDLC", 1, 0, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_marsh", "", "", "", "", "", "尖刺灌木常见于草原和森林，它可以提供一个树枝(采摘时受到3点伤害，可以直接铲起以避免伤害)。尖刺灌木可以移植，但是不能种植在方格地板、木质地板、卵石路、地毯地板、岩石草皮、沙地、洞穴石地上。生长需要4天时间。", False, True)
    End Sub

    Private Sub button_N_cactus_click(sender As Object, e As RoutedEventArgs) Handles button_N_cactus.Click
        NP_Picture({"N_cactus", "N_cactus_flower", "N_cactus_empty"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"F_cactus_flesh", "×1", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(1, 1, {"F_cactus_flesh", "×1", "F_cactus_flower", "×1(仅夏天)", "", "", "", "", "", "", "", ""})
        N_Show_P("仙人掌", "Cactus", "NoDLC", 1, 0, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_desert", "", "", "", "", "", "仙人掌只能在沙漠找到，采摘时受到6点伤害(可以穿防御型装备抵挡伤害)。不能移植。生长需要3天时间(冬天不受影响)，只有在夏天才能收获仙人掌花。", False, True)
    End Sub

    Private Sub button_N_plant_click(sender As Object, e As RoutedEventArgs) Handles button_N_plant.Click
        NP_Picture({"N_plant"})
        ReDim NP_ResourcesArray(0, 11)
        N_Show_P("种植", "Plant", "NoDLC", 1, 0, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "N_tidal_marsh", "", "", "", "", "随着池塘的生成而生成2-4株，不能捡起，但是会被火烧，每到夏天就会长回来。", True, True)
    End Sub

    Private Sub button_N_algae_click(sender As Object, e As RoutedEventArgs) Handles button_N_algae.Click
        NP_Picture({"N_algae"})
        ReDim NP_ResourcesArray(0, 11)
        N_Show_P("水藻", "Algae", "NoDLC", 1, 0, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_village", "N_wilds", "", "", "", "", "随着洞穴池塘的生成而生成2-4株，不能捡起，但是会被火烧，每到夏天就会长回来。", True, True)
    End Sub

    Private Sub button_N_blue_mushroom_click(sender As Object, e As RoutedEventArgs) Handles button_N_blue_mushroom.Click
        NP_Picture({"N_blue_mushroom", "N_mushroom_inground", "N_mushroom_picked"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"F_blue_cap", "×1", "F_blue_cap", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 1, {"F_blue_cap", "×1", "F_blue_cap", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(2, 2, {"F_blue_cap", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("蓝蘑菇", "Blue Mushroom", "NoDLC", 1, 1, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_forest", "N_blue_mushtree_forest", "", "", "", "", "蓝蘑菇晚上才会长出来，也可以砍蓝色蘑菇树获取。蓝蘑菇炒烤蓝蘑菇，味道一定不错！", False, True)
    End Sub

    Private Sub button_N_green_mushroom_click(sender As Object, e As RoutedEventArgs) Handles button_N_green_mushroom.Click
        NP_Picture({"N_green_mushroom", "N_mushroom_inground", "N_mushroom_picked"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"F_green_cap", "×1", "F_green_cap", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 1, {"F_green_cap", "×1", "F_green_cap", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(2, 2, {"F_green_cap", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("绿蘑菇", "Green Mushroom", "NoDLC", 1, 1, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_marsh", "N_green_mushtree_forest", "", "", "", "", "绿蘑菇黄昏才会长出来，也可以砍绿色蘑菇树获取。直接食用降低50点精神，所以要烤了吃。", False, True)
    End Sub

    Private Sub button_N_red_mushroom_click(sender As Object, e As RoutedEventArgs) Handles button_N_red_mushroom.Click
        NP_Picture({"N_red_mushroom", "N_mushroom_inground", "N_mushroom_picked"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"F_red_cap", "×1", "F_red_cap", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 1, {"F_red_cap", "×1", "F_red_cap", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(2, 2, {"F_red_cap", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("红蘑菇", "Red Mushroom", "NoDLC", 1, 1, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "N_red_mushtree_forest", "", "", "", "", "红蘑菇白天才会长出来，也可以砍红色蘑菇树获取。放在地上可以间接地让怪物吃它而受到伤害。", False, True)
    End Sub

    Private Sub button_N_light_flower_1_click(sender As Object, e As RoutedEventArgs) Handles button_N_light_flower_1.Click
        NP_Picture({"N_light_flower_springy", "N_light_flower_springy_empty", "N_light_flower_1", "N_light_flower_empty_1", "N_light_flower_2", "N_light_flower_empty_2", "N_light_flower_3", "N_light_flower_empty_3"})
        ReDim NP_ResourcesArray(7, 11)
        NP_Resources(0, 0, {"G_light_bulb", "×1", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(2, 2, {"G_light_bulb", "×1", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(4, 4, {"G_light_bulb", "×2", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(6, 6, {"G_light_bulb", "×3", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("荧光草", "Light Flower", "NoDLC", 1, 0, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_wilds", "N_light_flower_swamp", "", "", "", "", "在荧光草沼泽可以找到大量荧光草，不能移植。荧光草的外貌暴露了它可以收获几个荧光果，荧光果可以给矿工帽、提灯、水瓶提灯、船灯添加燃料。荧光草会发光，采摘后3天长出一个荧光果，4-5天长出两个荧光果，6天长出三个荧光果。", False, True)
    End Sub

    Private Sub button_N_fern_1_click(sender As Object, e As RoutedEventArgs) Handles button_N_fern_1.Click
        NP_Picture("N_fern_", 10)
        NP_Resources(10, {"G_foliage", "×1", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("蕨类植物", "Fern", "NoDLC", 1, 1, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_wilds", "", "", "", "", "", "蕨类植物是长在洞穴里的"“花"”，捡起可以得到蕨叶，吃了回复1点生命。蕨叶还有一个用处是制作盆栽的蕨类植物。", False, True)
    End Sub

    Private Sub button_N_cave_lichen_click(sender As Object, e As RoutedEventArgs) Handles button_N_cave_lichen.Click
        NP_Picture({"N_cave_lichen", "N_cave_lichen_empty"})
        ReDim NP_ResourcesArray(1, 11)
        NP_Resources(0, 0, {"F_lichen", "×1", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("洞穴苔藓", "Cave Lichen", "NoDLC", 1, 1, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_wilds", "", "", "", "", "", "洞穴苔藓通常可以在野外找到，不能移植。采摘后获得一个苔藓，5天后再次成熟。", False, True)
    End Sub

    Private Sub button_N_grass_sw_click(sender As Object, e As RoutedEventArgs) Handles button_N_grass_sw.Click
        NP_Picture({"N_grass_sw", "N_grass_empty_sw", "N_grass_dead"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"G_cut_grass_SW", "×1", "G_grass_tuft_SW", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 2, {"G_grass_tuft_SW", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("船难草", "Grass(SW)", "SW", 0, 1, 0, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_beach", "N_meadow", "", "", "", "", "船难草常见于海滩，它可以提供一个干草。船难草可以移植，但是不能种植在方格地板、木质地板、卵石路、地毯地板、岩石草皮、沙地、洞穴石地上。移植的船难草需要施肥(便便、鸟屎、便便篮)，生长需要3天时间(下雨会减少生长时间。", False, True)
    End Sub

    Private Sub button_N_bamboo_patch_click(sender As Object, e As RoutedEventArgs) Handles button_N_bamboo_patch.Click
        NP_Picture({"N_bamboo_patch", "N_bamboo_patch_empty", "N_bamboo_patch_dead"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"G_bamboo_patch", "×1(           )", "G_bamboo_root", "×1(                      )", "", "", "", "", "S_machete", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 2, {"G_bamboo_root", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("竹子", "Bamboo Patch", "SW", 0, 1, 0, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_jungle", "", "", "", "", "", "用砍刀砍可以得到竹子，可以移植，需要施肥。", False, True)
    End Sub

    Private Sub button_N_viney_bush_click(sender As Object, e As RoutedEventArgs) Handles button_N_viney_bush.Click
        NP_Picture({"N_viney_bush", "N_viney_bush_empty", "N_viney_bush_dead"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"G_vine", "×1(           )", "G_viney_bush_root", "×1(                      )", "", "", "", "", "S_machete", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 2, {"G_viney_bush_root", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("藤蔓丛", "Viney Bush", "SW", 0, 1, 0, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_jungle", "", "生成", "A_snake", "生成", "A_poison_snake", "用砍刀砍可以得到藤蔓，生长需要4天时间。一些藤蔓丛会有蛇出没(有蛇的藤蔓丛会发生声音和周期性震动)。蛇会在黄昏离开藤蔓丛，整个晚上在外面游荡，并且在白天回来。每个藤蔓丛最多含有三条蛇，击杀后每90秒重新生成一条。可以移植，移植的藤蔓丛不会产生蛇。", False, True)
    End Sub

    Private Sub button_N_seaweed_click(sender As Object, e As RoutedEventArgs) Handles button_N_seaweed.Click
        NP_Picture({"N_seaweed", "N_seaweed_empty"})
        ReDim NP_ResourcesArray(1, 11)
        NP_Resources(0, 0, {"F_seaweed", "×1", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("海藻", "Seaweed", "SW", 0, 1, 0, "NoTool", "", "", "", "", "", "", "", "", "N_ocean_shallow", "", "", "", "", "", "海藻可以在浅海中找到，有时候会成片出现。采集的海藻可以做一些食物。", True, False)
    End Sub

    Private Sub button_N_coffee_plant_click(sender As Object, e As RoutedEventArgs) Handles button_N_coffee_plant.Click
        NP_Picture({"N_coffee_plant", "N_coffee_plant_empty", "N_coffee_plant_dead"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"F_coffee_beans", "×1", "G_coffee_plant", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 2, {"G_coffee_plant", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("咖啡树", "Coffee Plant", "SW", 0, 1, 0, "NoTool", "", "", "", "", "", "", "", "", "N_volcano_bio", "", "", "", "", "", "咖啡树只生长在火山里，采摘可以得到一个咖啡豆，生长需要4-5天(不受下雨影响)。咖啡树可以移植，但是只能种在火山地皮上，移植的咖啡树生长只需要3-5天。给咖啡树施肥需要灰烬而不是便便。那些没有移植的咖啡树只会在干燥季节生长。咖啡树不会被火烧，不会被雷劈。", False, False)
    End Sub

    Private Sub button_N_elephant_cactus_click(sender As Object, e As RoutedEventArgs) Handles button_N_elephant_cactus.Click
        NP_Picture({"N_elephant_cactus", "N_elephant_cactus_dead", "N_elephant_cactus_stump"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"G_cactus_spike", "×1", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(1, 1, {"G_twigs", "×2(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        NP_Resources(2, 2, {"G_elephant_cactus_stump", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("象仙人掌", "Elephant Cactus", "SW", 0, 1, 0, "NoTool", "", "", "", "", "", "", "", "", "N_volcano_bio", "", "", "", "", "", "象仙人掌只生长在火山里，它们只在干燥季节活跃。靠近象仙人掌会受到20点AOE伤害，每次攻击象仙人掌，它将使攻击者受到10点伤害。穿着象仙人掌盔甲尽管可以免疫象仙人掌的AOE攻击，但是无法抵挡反击伤害。象仙人掌死亡后会掉落象仙人掌刺并且缩小，这时可以用铲子挖起移植，象仙人掌只能种植在岩浆地皮、灰色地皮和火山地皮上。象仙人掌不会被火烧。", False, False)
    End Sub

    Private Sub button_N_sapling_diseased_click(sender As Object, e As RoutedEventArgs) Handles button_N_sapling_diseased.Click
        NP_Picture({"N_sapling_diseased", "N_sapling_diseased_empty"})
        ReDim NP_ResourcesArray(1, 11)
        NP_Resources(0, 0, {"F_rot", "×1", "G_sapling", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 1, {"G_sapling", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("患病的树苗", "Diseased Sapling", "DST", 0, 0, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "N_forest", "", "", "", "", "患病后一段时间消失，患病无法治疗，但是用铲子铲起可以得到全新的树苗。", False, True)
    End Sub

    Private Sub button_N_grass_diseased_click(sender As Object, e As RoutedEventArgs) Handles button_N_grass_diseased.Click
        NP_Picture({"N_grass_diseased", "N_grass_diseased_dead", "N_grass_diseased_empty"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"F_rot", "×1", "G_grass_tuft", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 2, {"G_grass_tuft", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("患病的草", "Diseased Grass", "DST", 0, 0, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "", "", "", "", "", "患病后一段时间消失，患病无法治疗，但是用铲子铲起可以得到全新的长草簇。", False, True)
    End Sub

    Private Sub button_N_berry_bush_diseased_click(sender As Object, e As RoutedEventArgs) Handles button_N_berry_bush_diseased.Click
        NP_Picture({"N_berry_bush_diseased", "N_berry_bush_diseased_empty", "N_berry_bush_diseased_dead"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"F_rot", "×1", "G_berry_bush", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 1, {"G_berry_bush", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        NP_Resources(2, 2, {"G_twigs", "×2(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("患病的浆果灌木丛", "Diseased Berry Bush", "DST", 0, 0, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "N_forest", "", "", "", "", "患病后一段时间消失，患病无法治疗，但是用铲子铲起可以得到全新的浆果灌木丛。", False, True)
    End Sub

    Private Sub button_N_juicy_berry_bush_diseased_click(sender As Object, e As RoutedEventArgs) Handles button_N_juicy_berry_bush_diseased.Click
        NP_Picture({"N_juicy_berry_bush", "N_juicy_berry_bush_empty", "N_juicy_berry_bush_dead"})
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"F_rot", "×1", "G_juicy_berry_bush", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel"})
        NP_Resources(1, 1, {"G_juicy_berry_bush", "×1(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        NP_Resources(2, 2, {"G_twigs", "×2(                      )", "", "", "", "", "", "", "S_shovel", "S_goldenshovel", "", ""})
        N_Show_P("患病的蜜汁浆果丛", "Diseased Juicy Berry Bush", "DST", 0, 0, 1, "NoTool", "G_ash", "×1", "", "", "", "", "", "", "N_grasslands", "N_forest", "", "", "", "", "患病后一段时间消失，患病无法治疗，但是用铲子铲起可以得到全新的蜜汁浆果丛。", False, True)
    End Sub

    Private Sub button_N_evergreen_click(sender As Object, e As RoutedEventArgs) Handles button_N_evergreen.Click
        NP_Picture("N_evergreen_", 4)
        ReDim NP_ResourcesArray(3, 11)
        NP_Resources(0, 0, {"G_log", "×1", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(1, 1, {"G_log", "×2", "G_pine_cone", "×1", "", "", "", "", "", "", "", ""})
        NP_Resources(2, 2, {"G_log", "×3", "G_pine_cone", "×2", "", "", "", "", "", "", "", ""})
        N_Show_P("常青树", "Evergreen", "NoDLC", 1, 1, 1, "Normal", "G_charcoal", "×1", "G_charcoal", "×1(一定几率)", "G_pine_cone", "×1(一定几率)", "", "", "N_grasslands", "N_forest", "生成", "A_treeguard", "", "", "常青树十分常见，除了稀树大草原和矿区，都能看到它的身影。常青树是松果和木材的主要来源，可以被猪人随从砍伐。砍伐常青树的次数为5(小)/10(中)/15(大)/1(老)次。常青树会随着时间变化在小、中、大、老这个生长周期中不断循环。一旦砍伐，树墩不会长成常青树。第四天开始，每次砍伐常青树都有1.3%的几率产生树精守卫(包括自己种的)，树精守卫的速度并不快，可以通过种植常青树平息树精守卫的愤怒。联机版中，常青树在一段时间后会变成石化树。", True, True)
    End Sub

    Private Sub button_N_lumpy_evergreen_click(sender As Object, e As RoutedEventArgs) Handles button_N_lumpy_evergreen.Click
        NP_Picture("N_lumpy_evergreen_", 3)
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"G_log", "×1", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(1, 1, {"G_log", "×2", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(2, 2, {"G_log", "×3", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("粗壮常青树", "Lumpy Evergreen", "NoDLC", 1, 1, 1, "Normal", "G_charcoal", "×1", "G_charcoal", "×1(一定几率)", "", "", "", "", "N_forest", "", "生成", "A_treeguard", "", "", "粗壮常青树是常青树的变种，不会掉落松果。在联机版中，粗壮常青树是会随时间再生的。", False, True)
    End Sub

    Private Sub button_N_birchnut_tree_click(sender As Object, e As RoutedEventArgs) Handles button_N_birchnut_tree.Click
        NP_Picture("N_birchnut_tree_", 3, "N_birchnut_tree_old_", 3)
        ReDim NP_ResourcesArray(5, 11)
        NP_Resources(0, 0, {"G_log", "×1", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(1, 1, {"G_log", "×2", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(2, 2, {"G_log", "×3", "G_birchnut", "×2(秋天)", "G_birchnut", "×1(春天和夏天)", "", "", "", "", "", ""})
        NP_Resources(3, 3, {"G_log", "×1", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(4, 4, {"G_log", "×2", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(5, 5, {"G_log", "×3", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("桦树", "Birchnut Tree", "NoDLC", 1, 0, 1, "Normal", "G_charcoal", "×1", "G_charcoal", "×1(一定几率)", "G_birchnut", "×1(极小几率)", "", "", "N_grasslands", "N_deciduous_forest", "生成", "A_poison_birchnut_trees", "", "", "桦树一年四季的形态各不相同，冬天的桦树不会掉咯坚果。站在树下可以避雨，还能减缓过热。桦树是坚果和木材的主要来源，可以被猪人随从砍伐。砍伐桦树的次数为5(小)/10(中)/15(大)次。桦树会随着时间变化在小、中、大这个生长周期中不断循环。一旦砍伐，树墩不会长成桦树。第四天开始，每次砍伐桦树都有几率产生桦树精，桦树精至少需要一天时间或者通过种植坚果平息。桦树精最多可以产生5个坚果怪来攻击，并且还有远程的树根攻击。消灭桦树精需要用斧子砍伐。", True, True)
    End Sub

    Private Sub button_N_totally_normal_tree_click(sender As Object, e As RoutedEventArgs) Handles button_N_totally_normal_tree.Click
        NP_Picture({"N_totally_normal_tree"})
        NP_Resources(1, {"G_living_log", "×2", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("完全正常的树", "Totally Normal Tree", "NoDLC", 1, 0, 1, "Normal", "G_charcoal", "×1", "G_charcoal", "×1(一定几率)", "", "", "", "", "N_forest", "", "", "", "", "", "完全正常的树生长在森林生物群落，需要砍伐20次，可以获得两个活木，挖起树墩也可以获得一个活木。完全正常的树周围通常有一些恶魔之花。", False, True)
    End Sub

    Private Sub button_N_spiky_tree_click(sender As Object, e As RoutedEventArgs) Handles button_N_spiky_tree.Click
        NP_Picture("N_spiky_tree")
        NP_Resources(1, {"G_twigs", "×1", "G_log", "×1(20%)", "", "", "", "", "", "", "", ""})
        N_Show_P("针叶树", "Spiky Tree", "NoDLC", 1, 0, 1, "Normal", "G_twigs", "×1", "G_charcoal", "×1", "G_charcoal", "×1(一定几率)", "G_log", "×1(极小几率)", "N_marsh", "", "", "", "", "", "出现在沼泽和沙漠的树，不会随着时间而变化。", False, True)
    End Sub

    Private Sub button_N_blue_mushtree_click(sender As Object, e As RoutedEventArgs) Handles button_N_blue_mushtree.Click
        NP_Picture({"N_blue_mushtree", "N_blue_mushtree_blooming"})
        ReDim NP_ResourcesArray(1, 11)
        NP_Resources(0, 1, {"G_log", "×1", "F_blue_cap", "×1", "", "", "", "", "", "", "", ""})
        N_Show_P("蓝色蘑菇树", "Blue Mushtree", "NoDLC", 1, 0, 1, "Normal", "G_ash", "×1", "G_charcoal", "×1(一定几率)", "", "", "", "", "N_mushtree_forest", "", "生成", "A_blue_spore", "", "", "砍伐获得木材和蓝蘑菇，满月时，所有的蓝蘑菇都会变成蓝色蘑菇树(如果砍伐这种蓝色蘑菇树，那么满月结束后会变成采摘过的蓝蘑菇)。在联机版中，有额外的绽放阶段，会产生蓝色孢子。", False, True)
    End Sub

    Private Sub button_N_green_mushtree_click(sender As Object, e As RoutedEventArgs) Handles button_N_green_mushtree.Click
        NP_Picture({"N_green_mushtree", "N_green_mushtree_blooming"})
        ReDim NP_ResourcesArray(1, 11)
        NP_Resources(0, 1, {"G_log", "×1", "F_green_cap", "×1", "", "", "", "", "", "", "", ""})
        N_Show_P("绿色蘑菇树", "Green Mushtree", "NoDLC", 1, 0, 1, "Normal", "G_ash", "×1", "G_charcoal", "×1(一定几率)", "", "", "", "", "N_mushtree_forest", "", "生成", "A_green_spore", "", "", "砍伐获得木材和绿蘑菇，满月时，所有的绿蘑菇都会变成绿色蘑菇树(如果砍伐这种绿色蘑菇树，那么满月结束后会变成采摘过的绿蘑菇)。在联机版中，有额外的绽放阶段，会产生绿色孢子。", False, True)
    End Sub

    Private Sub button_N_red_mushtree_click(sender As Object, e As RoutedEventArgs) Handles button_N_red_mushtree.Click
        NP_Picture({"N_red_mushtree", "N_red_mushtree_blooming"})
        ReDim NP_ResourcesArray(1, 11)
        NP_Resources(0, 1, {"G_log", "×1", "F_red_cap", "×1", "", "", "", "", "", "", "", ""})
        N_Show_P("红色蘑菇树", "Red Mushtree", "NoDLC", 1, 0, 1, "Normal", "G_ash", "×1", "G_charcoal", "×1(一定几率)", "", "", "", "", "N_mushtree_forest", "", "生成", "A_red_spore", "", "", "砍伐获得木材和红蘑菇，满月时，所有的红蘑菇都会变成红色蘑菇树(如果砍伐这种红色蘑菇树，那么满月结束后会变成采摘过的红蘑菇)。在联机版中，有额外的绽放阶段，会产生红色孢子。", False, True)
    End Sub

    Private Sub button_N_webbed_blue_mushtree_click(sender As Object, e As RoutedEventArgs) Handles button_N_webbed_blue_mushtree.Click
        NP_Picture({"N_webbed_blue_mushtree"})
        NP_Resources(1, {"G_log", "×1", "G_silk", "×1", "G_silk", "×1(30%)", "G_silk", "×1(30%)", "", "", "", ""})
        N_Show_P("长满网的蓝色蘑菇树", "Webbed Blue Mushtree", "DST", 0, 0, 1, "Normal", "G_ash", "×1", "G_charcoal", "×1(一定几率)", "", "", "", "", "N_mushtree_forest", "", "生成", "A_dangling_depth_dweller", "", "", "蓝蘑菇树的变种，砍伐后会生成白蜘蛛。", False, True)
    End Sub

    Private Sub button_N_cave_banana_tree_click(sender As Object, e As RoutedEventArgs) Handles button_N_cave_banana_tree.Click
        NP_Picture({"N_cave_banana_tree"})
        NP_Resources(1, {"F_banana", "×1", "G_log", "×1", "G_twigs", "×2", "", "", "", "", "", ""})
        N_Show_P("洞穴香蕉树", "Cave Banana Tree", "NoDLC", 1, 0, 1, "Normal", "G_charcoal", "×1", "", "", "", "", "", "", "N_village", "", "", "", "", "", "洞穴香蕉树通常出现在野外采摘可以获得香蕉，生长需要4天。", False, True)
    End Sub

    Private Sub button_N_palm_tree_click(sender As Object, e As RoutedEventArgs) Handles button_N_palm_tree.Click
        NP_Picture("N_palm_tree_", 3)
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"G_log", "×1", "G_palm_leaf", "×1", "", "", "", "", "", "", "", ""})
        NP_Resources(1, 1, {"G_log", "×2", "G_palm_leaf", "×1", "", "", "", "", "", "", "", ""})
        NP_Resources(2, 2, {"G_log", "×2", "G_palm_leaf", "×1", "F_coconut", "×1", "", "", "", "", "", ""})
        N_Show_P("椰子树", "Palm Tree", "SW", 0, 1, 0, "Normal", "G_charcoal", "×1", "", "", "", "", "", "", "N_beach", "", "生成", "A_palm_treeguard", "", "", "椰子树通常可以在海滩找到。椰子树是椰子和木材的主要来源，可以被猪人随从砍伐。砍伐椰子树的次数为5(小)/10(中)/15(大)次。椰子树会随着时间变化在小、中、大这个生长周期中不断循环。一旦砍伐，树墩不会长成椰子树。第四天开始，每次砍伐椰子树都有1/75的几率产生椰树守卫(包括自己种的)。每次砍伐椰子树都有1%的几率砸下一个椰子造成20点伤害，掉落的椰子可以收集。", True, True)
    End Sub

    Private Sub button_N_jungle_tree_click(sender As Object, e As RoutedEventArgs) Handles button_N_jungle_tree.Click
        NP_Picture("N_jungle_tree_", 3)
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"G_log", "×1", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(1, 1, {"G_log", "×2", "G_jungle_tree_seed", "×1", "F_egg", "×1(50%)", "", "", "", "", "", ""})
        NP_Resources(2, 2, {"G_log", "×3", "G_jungle_tree_seed", "×2", "F_egg", "×1(25%)", "F_banana", "×1(25%)", "", "", "", ""})
        N_Show_P("丛林树", "Jungle Tree", "SW", 0, 1, 0, "Normal", "G_charcoal", "×1", "", "", "", "", "", "", "N_jungle", "", "生成", "A_snake", "生成", "A_poison_snake", "丛林树只能在热带雨林找到，它们是迄今为止最大的树。每次砍伐丛林树都有50%的几率产生蛇。", True, True)
    End Sub

    Private Sub button_N_mangrove_click(sender As Object, e As RoutedEventArgs) Handles button_N_mangrove.Click
        NP_Picture("N_mangrove_", 3)
        ReDim NP_ResourcesArray(2, 11)
        NP_Resources(0, 0, {"G_log", "×1", "G_twigs", "×1", "", "", "", "", "", "", "", ""})
        NP_Resources(1, 1, {"G_log", "×1", "G_twigs", "×2", "", "", "", "", "", "", "", ""})
        NP_Resources(2, 2, {"G_log", "×2", "G_twigs", "×3", "", "", "", "", "", "", "", ""})
        N_Show_P("红树林", "Mangrove", "SW", 0, 1, 0, "Normal", "G_charcoal", "×1", "", "", "", "", "", "", "N_mangrove_bio", "", "", "", "", "", "红树林生长在红树林生物群落，只能坐船拜访它们。截至目前，没有种植红树林的方法，但是只要没有完全摧毁它们，就会很快恢复。", False, True)
    End Sub

    Private Sub button_N_regular_jungle_tree_click(sender As Object, e As RoutedEventArgs) Handles button_N_regular_jungle_tree.Click
        NP_Picture({"N_regular_jungle_tree"})
        NP_Resources(1, {"G_living_log", "×2", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("正常的丛林树", "Regular Jungle Tree", "SW", 0, 1, 0, "Normal", "G_charcoal", "×1", "", "", "", "", "", "", "N_jungle", "", "", "", "", "", "船难版的完全正常的树。需要砍伐20次，可以获得两个活木，挖起树墩也可以获得一个活木。正常的丛林树周围通常有一些恶魔之花。", False, True)
    End Sub

    Private Sub button_N_burnt_ash_tree_click(sender As Object, e As RoutedEventArgs) Handles button_N_burnt_ash_tree.Click
        NP_Picture({"N_burnt_ash_tree"})
        NP_Resources(1, {"G_ash", "×1", "", "", "", "", "", "", "", "", "", ""})
        N_Show_P("烧焦的灰树", "Burnt Ash Tree", "SW", 0, 1, 0, "Normal", "", "", "", "", "", "", "", "", "N_volcano_bio", "", "", "", "", "", "生长在火山的树，砍伐后获得一个灰烬。", False, False)
    End Sub

    Private Sub button_N_brainy_sprout_click(sender As Object, e As RoutedEventArgs) Handles button_N_brainy_sprout.Click
        NP_Picture({"N_brainy_sprout"})
        NP_Resources(1, {"F_brainy_matter", "×1", "S_limestone", "×2(           )", "", "", "", "", "", "", "S_hammer", ""})
        N_Show_P("聪明芽", "Brainy Sprout", "SW", 0, 1, 0, "NoTool", "", "", "", "", "", "", "", "", "N_coral_reef_bio", "", "+25精神/分", "", "发光", "", "聪明芽生长在珊瑚礁生物群落。采摘获得聪明豆，生长需要20天。如果没有采摘，在黄昏和夜晚会发光，发光的时候有25精神/分的光环存在。", False, False)
    End Sub

    Private Sub button_N_twiggy_tree_click(sender As Object, e As RoutedEventArgs) Handles button_N_twiggy_tree.Click
        NP_Picture("N_twiggy_tree_", 4)
        ReDim NP_ResourcesArray(3, 11)
        NP_Resources(0, 0, {"G_twigs", "×1", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(1, 1, {"G_twigs", "×1", "G_log", "×2", "G_twiggy_tree_cone", "×1", "", "", "", "", "", ""})
        NP_Resources(2, 2, {"G_twigs", "×2", "G_log", "×3", "G_twiggy_tree_cone", "×2", "", "", "", "", "", ""})
        N_Show_P("多枝的树", "Twiggy Tree", "DST", 0, 0, 1, "Normal", "G_charcoal", "×1", "G_charcoal", "×1(一定几率)", "G_twigs", "×1(一定几率)", "", "", "N_forest", "", "", "", "", "", "游戏开始两个季节之后，树苗逐渐变成多枝的树，多枝的树周围会随机掉落树枝。多枝的树会患病。", False, True)
    End Sub

    Private Sub button_N_twiggy_tree_diseased_click(sender As Object, e As RoutedEventArgs) Handles button_N_twiggy_tree_diseased.Click
        NP_Picture("N_twiggy_tree_diseased_", 4)
        ReDim NP_ResourcesArray(3, 11)
        NP_Resources(0, 0, {"G_twigs", "×1", "", "", "", "", "", "", "", "", "", ""})
        NP_Resources(1, 1, {"G_twigs", "×1", "G_log", "×2", "G_twiggy_tree_cone", "×1", "", "", "", "", "", ""})
        NP_Resources(2, 2, {"G_twigs", "×2", "G_log", "×3", "G_twiggy_tree_cone", "×2", "", "", "", "", "", ""})
        N_Show_P("患病的多枝的树", "Diseased Twiggy Tree", "DST", 0, 0, 1, "Normal", "G_charcoal", "×1", "G_charcoal", "×1(一定几率)", "G_twigs", "×1(一定几率)", "", "", "N_forest", "", "", "", "", "", "患病后一段时间消失，患病无法治疗。", False, True)
    End Sub

    Private Sub button_N_petrified_tree_click(sender As Object, e As RoutedEventArgs) Handles button_N_petrified_tree.Click
        NP_Picture("N_petrified_tree_", 4)
        ReDim NP_ResourcesArray(3, 11)
        NP_Resources(0, 0, {"G_flint", "×1(35%几率额外获得一个)", "G_nitre", "×1(25%)", "G_rocks", "×1(25%几率额外获得一个)", "", "", "", "", "", ""})
        NP_Resources(1, 1, {"G_flint", "×1(75%几率额外获得一个)", "G_nitre", "×1(25%)", "G_rocks", "×1(40%)", "", "", "", "", "", ""})
        NP_Resources(2, 2, {"G_flint", "×2(35%几率额外获得一个)", "G_nitre", "×1(75%)", "G_rocks", "×1(65%)", "", "", "", "", "", ""})
        NP_Resources(3, 3, {"G_flint", "×1(50%)", "G_nitre", "×1(75%)", "G_rocks", "×1(25%)", "", "", "", "", "", ""})
        N_Show_P("石化树", "Petrified Tree", "DST", 0, 0, 1, "PetrifiedTree", "", "", "", "", "", "", "", "", "N_grasslands", "N_forest", "", "", "", "", "石化树由常青树变种而来，当常青树石化后，石化树就不会生长了。", True, False)
    End Sub
#End Region

#End Region

#Region "物品"
    Private Sub button_G_bamboo_patch_click(sender As Object, e As RoutedEventArgs) Handles button_G_bamboo_patch.Click
        G_Science(12, {"S_raft", "S_thatch_sail", "S_cloth_sail", "S_feather_lite_sail", "S_trawl_net", "S_buoy", "S_palm_leaf_hut", "S_mussel_stick", "S_ice_maker_3000", "S_spear_gun", "S_wildbore_house", "S_cloth"})
        G_Animal(0, {})
        G_Show_M("竹子", "Bamboo Patch", "G_bamboo_patch", "SW", 0, 1, 0, "砍竹子获得。")
    End Sub

    Private Sub button_G_cut_grass_SW_click(sender As Object, e As RoutedEventArgs) Handles button_G_cut_grass_SW.Click
        G_Science(17, {"S_hammer", "S_campfire", "S_torch", "S_endothermic_fire", "S_lantern_1", "S_log_raft", "S_telltale_heart", "S_trap", "S_pretty_parasol", "S_backpack", "S_straw_roll", "S_basic_farm", "S_improved_farm", "S_grass_suit", "S_hay_wall", "S_straw_hat", "S_rope"})
        G_Animal(0, {})
        G_Show_M("干草", "Cut Grass(SW)", "G_cut_grass_SW", "SW", 0, 1, 0, "采集草获得。")
    End Sub

    Private Sub button_G_vine_click(sender As Object, e As RoutedEventArgs) Handles button_G_vine.Click
        G_Science(8, {"S_raft", "S_row_boat", "S_thatch_sail", "S_life_jacket", "S_sea_sack", "S_mussel_stick", "S_snakeskin_jacket", "S_sleek_hat"})
        G_Animal(0, {})
        G_Show_M("藤蔓", "Vine", "G_vine", "SW", 0, 1, 0, "砍藤蔓从获得。")
    End Sub

    Private Sub button_G_sand_click(sender As Object, e As RoutedEventArgs) Handles button_G_sand.Click
        G_Science(4, {"S_chiminea", "S_sandbag", "S_sand_castle", "S_empty_bottle"})
        G_Animal(0, {})
        G_Show_M("沙子", "Sand", "G_sand", "SW", 0, 1, 0, "挖沙堆获得。")
    End Sub

    Private Sub button_G_snakeskin_click(sender As Object, e As RoutedEventArgs) Handles button_G_snakeskin.Click
        G_Science(5, {"S_snakeskin_sail", "S_silly_monkey_ball", "S_snakeskin_rug", "S_snakeskin_hat", "S_snakeskin_jacket"})
        G_Animal(2, {"A_snake", "A_poison_snake"})
        G_Show_M("蛇皮", "Snakeskin", "G_snakeskin", "SW", 0, 1, 0, "击杀蛇和毒蛇获得。")
    End Sub

    Private Sub button_G_snake_oil_click(sender As Object, e As RoutedEventArgs) Handles button_G_snake_oil.Click
        G_Science(0, {})
        G_Animal(2, {"A_snake", "A_poison_snake"})
        G_Show_M("蛇油", "Snake Oil", "G_snake_oil", "SW", 0, 1, 0, "击杀蛇和毒蛇获得。")
    End Sub

    Private Sub button_G_palm_leaf_click(sender As Object, e As RoutedEventArgs) Handles button_G_palm_leaf.Click
        G_Science(8, {"S_thatch_sail", "S_sea_trap", "S_tropical_parasol", "S_thatch_pack", "S_palm_leaf_hut", "S_wildbore_house", "S_sand_castle", "S_blubber_suit"})
        G_Animal(0, {})
        G_Show_M("椰树叶", "Palm Leaf", "G_palm_leaf", "SW", 0, 1, 0, "砍倒椰子树获得。")
    End Sub

    Private Sub button_G_venom_gland_click(sender As Object, e As RoutedEventArgs) Handles button_G_venom_gland.Click
        G_Science(3, {"S_anti_venom", "S_poison_spear", "S_poison_dart"})
        G_Animal(4, {"A_spider_warrior_sw", "A_poison_snake", "A_stink_ray", "A_mosquito_sw"})
        G_Show_M("毒蛇腺体", "Venom Gland", "G_venom_gland", "SW", 0, 1, 0, "击杀毒蜘蛛、毒蛇、恶臭魔鬼鱼和毒蚊子获得。")
    End Sub

    Private Sub button_G_yellow_mosquito_sack_click(sender As Object, e As RoutedEventArgs) Handles button_G_yellow_mosquito_sack.Click
        G_Science(0, {})
        G_Animal(1, {"A_mosquito_sw"})
        G_Show_M("黄色蚊子血袋", "Yellow Mosquito Sack", "G_yellow_mosquito_sack", "SW", 0, 1, 0, "击杀毒蚊子获得。")
    End Sub

    Private Sub button_G_seashell_click(sender As Object, e As RoutedEventArgs) Handles button_G_seashell.Click
        G_Science(5, {"S_surfboard", "S_armoured_boat", "S_seashell_suit", "S_horned_helmet", "S_sand_castle"})
        G_Animal(0, {})
        G_Show_M("贝壳", "Seashell", "G_seashell", "SW", 0, 1, 0, "挖沙堆有几率获得，有时候海滩也可以捡到。", False, True)
    End Sub

    Private Sub button_G_doydoy_feather_click(sender As Object, e As RoutedEventArgs) Handles button_G_doydoy_feather.Click
        G_Science(3, {"S_feather_lite_sail", "S_tropical_fan", "S_doydoy_nest"})
        G_Animal(3, {"A_baby_doydoy", "A_doydoy_child", "A_doydoy"})
        G_Show_M("渡渡鸟的羽毛", "Doydoy Feather", "G_doydoy_feather", "SW", 0, 1, 0, "击杀渡渡鸟获得。")
    End Sub

    Private Sub button_G_dubloons_click(sender As Object, e As RoutedEventArgs) Handles button_G_dubloons.Click
        G_Science(3, {"S_lucky_hat", "S_the_'sea_legs'", "S_gold_nugget"})
        G_Animal(0, {})
        G_Show_M("金币", "Dubloons", "G_dubloons", "SW", 0, 1, 0, "海盗鹦鹉会掉落金币，挖沙堆也可能会挖出金币。金币是船难版里另一种获得金块的方式。除了制作科技物品，还可以玩老虎机。", False, True)
    End Sub

    Private Sub button_G_hail_click(sender As Object, e As RoutedEventArgs) Handles button_G_hail.Click
        G_Science(1, {"S_ice"})
        G_Animal(0, {})
        G_Show_M("冰雹", "Hail", "G_hail", "SW", 0, 1, 0, "船难版里合成冰块的材料，在飓风季节伴随着风暴出现。有一天的保质期，放在冰箱里不会融化，靠近火融化得更快。可以用来熄灭火。")
    End Sub

    Private Sub button_G_horn_click(sender As Object, e As RoutedEventArgs) Handles button_G_horn.Click
        G_Science(2, {"S_horned_helmet", "S_dripple_pipes"})
        G_Animal(1, {"A_water_beefalo"})
        G_Show_M("角", "Horn", "G_horn", "SW", 0, 1, 0, "击杀水牛获得。")
    End Sub

    Private Sub button_G_coral_click(sender As Object, e As RoutedEventArgs) Handles button_G_coral.Click
        G_Science(3, {"S_anti_venom", "S_particulate_purifier", "S_limestone"})
        G_Animal(0, {})
        G_Show_M("珊瑚", "Coral", "G_coral", "SW", 0, 1, 0, "挖珊瑚礁或在海洋用拖网获得，也可以用钓竿或拖网在潮湿的坟墓处获得。是制作石灰石的重要材料。", False, True)
    End Sub

    Private Sub button_G_obsidian_click(sender As Object, e As RoutedEventArgs) Handles button_G_obsidian.Click
        G_Science(11, {"S_obsidian_fire_pit", "S_dragoon_den", "S_joy_of_volcanology", "S_obsidian_machete", "S_obsidian_axe", "S_obsidian_spear", "S_volcano_staff", "S_obsidian_armour", "S_obsidian_coconade", "S_howling_conch", "S_sail_stick"})
        G_Animal(0, {})
        G_Show_M("黑曜石", "Obsidian", "G_obsidian", "SW", 0, 1, 0, "熄灭熔岩池或炸毁黑曜岩获得。制作火山科技的重要材料。")
    End Sub

    Private Sub button_G_cactus_spike_click(sender As Object, e As RoutedEventArgs) Handles button_G_cactus_spike.Click
        G_Science(1, {"S_cactus_armour"})
        G_Animal(1, {"A_elephant_cactus"})
        G_Show_M("象仙人掌刺", "Cactus Spike", "G_cactus_spike", "SW", 0, 1, 0, "击杀刺人的象仙人掌获得。")
    End Sub

    Private Sub button_G_dragoon_heart_click(sender As Object, e As RoutedEventArgs) Handles button_G_dragoon_heart.Click
        G_Science(7, {"S_dragoon_den", "S_obsidian_machete", "S_obsidian_axe", "S_obsidian_spear", "S_volcano_staff", "S_obsidian_armour", "S_obsidian_coconade"})
        G_Animal(1, {"A_dragoon"})
        G_Show_M("龙人心", "Dragoon Heart", "G_dragoon_heart", "SW", 0, 1, 0, "击杀龙骑士获得。制作火山科技的重要材料。")
    End Sub

    Private Sub button_G_turbine_blades_click(sender As Object, e As RoutedEventArgs) Handles button_G_turbine_blades.Click
        G_Science(1, {"S_iron_wind"})
        G_Animal(1, {"A_sealnado"})
        G_Show_M("涡轮叶片", "Turbine Blades", "G_turbine_blades", "SW", 0, 1, 0, "击杀豹卷风获得，可以制作铁风牌发动机。")
    End Sub

    Private Sub button_G_magic_seal_click(sender As Object, e As RoutedEventArgs) Handles button_G_magic_seal.Click
        G_Science(2, {"S_howling_conch", "S_sail_stick"})
        G_Animal(1, {"A_seal"})
        G_Show_M("豹印", "Magic Seal", "G_magic_seal", "SW", 0, 1, 0, "击杀豹卷风后产生的海豹处获得，可以用来制作呼啸的海螺和帆棍。")
    End Sub

    Private Sub button_G_shark_gills_click(sender As Object, e As RoutedEventArgs) Handles button_G_shark_gills.Click
        G_Science(2, {"S_sea_sack", "S_dumbrella"})
        G_Animal(2, {"A_tiger_shark", "A_sharkitten"})
        G_Show_M("鲨鱼腮", "Shark Gills", "G_shark_gills", "SW", 0, 1, 0, "击杀虎鲨和小虎鲨获得，用来制作海上麻袋和双层伞帽。")
    End Sub

    Private Sub button_G_ancient_vase_click(sender As Object, e As RoutedEventArgs) Handles button_G_ancient_vase.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("古老的花瓶", "Ancient Vase", "T_ancient_vase", "SW", 0, 1, 0, "", True, True)
    End Sub

    Private Sub button_G_brain_cloud_pill_click(sender As Object, e As RoutedEventArgs) Handles button_G_brain_cloud_pill.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("脑云丸", "Brain Cloud Pill", "T_brain_cloud_pill", "SW", 0, 1, 0, "", True, True)
    End Sub

    Private Sub button_G_broken_AAC_device_click(sender As Object, e As RoutedEventArgs) Handles button_G_broken_AAC_device.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("破碎的音频编码设备", "Broken AAC Device", "T_broken_AAC_device", "SW", 0, 1, 0, "", True, True)
    End Sub

    Private Sub button_G_license_plate_click(sender As Object, e As RoutedEventArgs) Handles button_G_license_plate.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("号码牌", "License Plate", "T_license_plate", "SW", 0, 1, 0, "", True, True)
    End Sub

    Private Sub button_G_old_boot_click(sender As Object, e As RoutedEventArgs) Handles button_G_old_boot.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("旧靴子", "Old Boot", "T_old_boot", "SW", 0, 1, 0, "", True, True)
    End Sub

    Private Sub button_G_one_true_earring_click(sender As Object, e As RoutedEventArgs) Handles button_G_one_true_earring.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("至尊耳环", "One True Earring", "T_one_true_earring", "SW", 0, 1, 0, "", True, True)
    End Sub

    Private Sub button_G_orange_soda_click(sender As Object, e As RoutedEventArgs) Handles button_G_orange_soda.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("橘子汽水", "Orange Soda", "T_orange_soda", "SW", 0, 1, 0, "", True, True)
    End Sub

    Private Sub button_G_sea_worther_click(sender As Object, e As RoutedEventArgs) Handles button_G_sea_worther.Click
        G_Science(1, {"S_Seaworthy"})
        G_Animal(0, {})
        G_Show_M("沃尔特海", "Sea Worther", "T_sea_worther", "SW", 0, 1, 0, "", True, False)
    End Sub

    Private Sub button_G_sextant_click(sender As Object, e As RoutedEventArgs) Handles button_G_sextant.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("六分仪", "Sextant", "T_sextant", "SW", 0, 1, 0, "", True, True)
    End Sub

    Private Sub button_G_soaked_candle_click(sender As Object, e As RoutedEventArgs) Handles button_G_soaked_candle.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("浸泡过的蜡烛", "Soaked Candle", "T_soaked_candle", "SW", 0, 1, 0, "", True, False)
    End Sub

    Private Sub button_G_toy_boat_click(sender As Object, e As RoutedEventArgs) Handles button_G_toy_boat.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("玩具船", "Toy Boat", "T_toy_boat", "SW", 0, 1, 0, "", True, True)
    End Sub

    Private Sub button_G_ukulele_click(sender As Object, e As RoutedEventArgs) Handles button_G_ukulele.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("四弦琴", "Ukulele", "T_ukulele", "SW", 0, 1, 0, "", True, True)
    End Sub

    Private Sub button_G_voodoo_doll_click(sender As Object, e As RoutedEventArgs) Handles button_G_voodoo_doll.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("巫毒娃娃", "Voodoo Doll", "T_voodoo_doll", "SW", 0, 1, 0, "", True, True)
    End Sub

    Private Sub button_G_wine_bottle_candle_click(sender As Object, e As RoutedEventArgs) Handles button_G_wine_bottle_candle.Click
        G_Science(0, {})
        G_Animal(0, {})
        G_Show_M("酒瓶蜡烛", "Wine Bottle Candle", "T_wine_bottle_candle", "SW", 0, 1, 0, "", True, True)
    End Sub
#End Region

#Region "物品_装备"

    Private Sub button_G_machete_click(sender As Object, e As RoutedEventArgs) Handles button_G_machete.Click
        G_Show_E("砍刀", "Machete", "S_machete", "SW", 0, 1, 0, "", "", "", "", "除了用作工具还能用来打怪。", {29.92, 0, 0, 0, 100, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_luxury_machete_click(sender As Object, e As RoutedEventArgs) Handles button_G_luxury_machete.Click
        G_Show_E("黄金砍刀", "Luxury Machete", "S_luxury_machete", "SW", 0, 1, 0, "", "", "", "", "除了用作工具还能用来打怪。", {29.92, 0, 0, 0, 400, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_obsidian_machete_click(sender As Object, e As RoutedEventArgs) Handles button_G_obsidian_machete.Click
        G_Show_E("黑曜石砍刀", "Obsidian Machete", "S_obsidian_machete", "SW", 0, 1, 0, "", "", "", "", "除了用作工具还能用来打怪。", {0, 29.92, 59.84, 0, 250, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_obsidian_axe_click(sender As Object, e As RoutedEventArgs) Handles button_G_obsidian_axe.Click
        G_Show_E("黑曜石斧", "Obsidian Axe", "S_obsidian_axe", "SW", 0, 1, 0, "", "", "", "", "除了用作工具还能用来打怪。", {0, 27.2, 54.4, 0, 250, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_sleek_hat_click(sender As Object, e As RoutedEventArgs) Handles button_G_sleek_hat.Click
        G_Show_E("星芒头盔", "Sleek Hat", "S_sleek_hat", "SW", 0, 1, 0, "", "", "", "", "增加25%的移动速度，还能抵御些寒风。", {0, 0, 0, 0, 0, 0, 6, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_rawling_click(sender As Object, e As RoutedEventArgs) Handles button_G_rawling.Click
        G_Show_E("罗林", "Rawling", "G_rawling", "SW", 0, 1, 0, "", "", "", "", "可以在深海发现它，带在身上有精神光环，每抛一次也会加1点精神。", {0, 0, 0, 0, 0, 1000, 0, 0, 0, 0, 2})
    End Sub

    Private Sub button_G_pirate_hat_click(sender As Object, e As RoutedEventArgs) Handles button_G_pirate_hat.Click
        G_Show_E("海盗帽", "Pirate Hat", "S_pirate_hat", "SW", 0, 1, 0, "", "", "", "", "拥有少量防潮效果。", {0, 0, 0, 0, 0, 0, 2, 0, 20, 0, 2})
    End Sub

    Private Sub button_G_tropical_parasol_click(sender As Object, e As RoutedEventArgs) Handles button_G_tropical_parasol.Click
        G_Show_E("热带遮阳伞", "tropical Parasol", "S_tropical_parasol", "SW", 0, 1, 0, "", "", "", "", "既防潮又隔热。", {0, 0, 0, 0, 0, 0, 2, 0, 20, 120, 2})
    End Sub

    Private Sub button_G_snakeskin_hat_click(sender As Object, e As RoutedEventArgs) Handles button_G_snakeskin_hat.Click
        G_Show_E("蛇鳞帽", "Snakeskin Hat", "S_snakeskin_hat", "SW", 0, 1, 0, "", "", "", "", "除了防潮还能防电！", {0, 0, 0, 0, 0, 0, 10, 0, 70, 0, 0})
    End Sub

    Private Sub button_G_snakeskin_jacket_click(sender As Object, e As RoutedEventArgs) Handles button_G_snakeskin_jacket.Click
        G_Show_E("蛇鳞上衣", "Snakeskin Jacket", "S_snakeskin_jacket", "SW", 0, 1, 0, "", "", "", "", "除了防潮还能防电！", {0, 0, 0, 0, 0, 0, 8, 0, 70, 0, 0})
    End Sub

    Private Sub button_G_blubber_suit_click(sender As Object, e As RoutedEventArgs) Handles button_G_blubber_suit.Click
        G_Show_E("鲸脂套装", "Blubber Suit", "S_blubber_suit", "SW", 0, 1, 0, "", "", "", "", "无敌的防潮效果！", {0, 0, 0, 0, 0, 0, 10, 0, 100, 60, 0})
    End Sub

    Private Sub button_G_dumbrella_click(sender As Object, e As RoutedEventArgs) Handles button_G_dumbrella.Click
        G_Show_E("双层伞帽", "Dumbrella", "S_dumbrella", "SW", 0, 1, 0, "", "", "", "", "船难版的眼球伞，无敌的防潮效果！隔热效果也是绝佳！", {0, 0, 0, 0, 0, 0, 9, 0, 100, 240, 0})
    End Sub

    Private Sub button_G_windbreaker_click(sender As Object, e As RoutedEventArgs) Handles button_G_windbreaker.Click
        G_Show_E("风衣", "Windbreaker", "S_windbreaker", "SW", 0, 1, 0, "", "", "", "", "有少量的防潮效果，并且防风。", {0, 0, 0, 0, 0, 0, 12, 0, 20, 240, 0})
    End Sub

    Private Sub button_G_boat_cannon_click(sender As Object, e As RoutedEventArgs) Handles button_G_boat_cannon.Click
        G_Show_E("船载加农炮", "Boat Cannon", "S_boat_cannon", "SW", 0, 1, 0, "", "", "", "", "装在船上的攻击性武器。", {100, 0, 0, 0, 15, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_coconade_click(sender As Object, e As RoutedEventArgs) Handles button_G_coconade.Click
        G_Show_E("椰壳炸弹", "Coconade", "S_coconade", "SW", 0, 1, 0, "", "", "", "", "火药升级版，Boom！Boom！", {250, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_obsidian_coconade_click(sender As Object, e As RoutedEventArgs) Handles button_G_obsidian_coconade.Click
        G_Show_E("黑曜石炸弹", "Obsidian Coconade", "S_obsidian_coconade", "SW", 0, 1, 0, "", "", "", "", "椰壳炸弹升级版，Boom！Boom！Boom！", {340, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_poison_spear_click(sender As Object, e As RoutedEventArgs) Handles button_G_poison_spear.Click
        G_Show_E("毒矛", "Poison Spear", "S_poison_spear", "SW", 0, 1, 0, "攻击带毒", "", "", "", "攻击伤害和长矛一致，附带毒。", {34, 0, 0, 0, 150, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_poison_dart_click(sender As Object, e As RoutedEventArgs) Handles button_G_poison_dart.Click
        G_Show_E("毒镖", "Poison Dart", "S_poison_dart", "SW", 0, 1, 0, "", "", "", "", "顾名思义，让对手中毒。", {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_spear_gun_click(sender As Object, e As RoutedEventArgs) Handles button_G_spear_gun.Click
        G_Show_E("矛枪", "Spear Gun", "S_spear_gun", "SW", 0, 1, 0, "", "", "", "", "可以装载战斗长矛、长矛、毒矛、黑曜石矛，射出去的矛要自己捡回来。", {0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_cutlass_supreme_click(sender As Object, e As RoutedEventArgs) Handles button_G_cutlass_supreme.Click
        G_Show_E("旗鱼短剑", "Cutlass Supreme", "S_cutlass_supreme", "SW", 0, 1, 0, "", "", "", "", "攻击力不错。", {68, 0, 0, 0, 150, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_obsidian_spear_click(sender As Object, e As RoutedEventArgs) Handles button_G_obsidian_spear.Click
        G_Show_E("黑曜石矛", "Obsidian Spear", "S_obsidian_spear", "SW", 0, 1, 0, "", "", "", "", "越打越来劲。", {0, 51, 102, 0, 375, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_eyeshot_click(sender As Object, e As RoutedEventArgs) Handles button_G_eyeshot.Click
        G_Show_E("眼睛吹箭", "Eyeshot", "G_eyeshot", "SW", 0, 1, 0, "", "", "A_flup", "", "只有追踪性弹涂鱼才会掉落，打中小鸟会让小鸟眩晕5秒。", {20, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_harpoon_click(sender As Object, e As RoutedEventArgs) Handles button_G_harpoon.Click
        G_Show_E("鱼叉", "Harpoon", "G_harpoon", "SW", 0, 1, 0, "", "", "A_white_whale", "", "超高攻击力。", {200, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_peg_leg_click(sender As Object, e As RoutedEventArgs) Handles button_G_peg_leg.Click
        G_Show_E("假腿", "Peg Leg", "G_peg_leg", "SW", 0, 1, 0, "", "", "", "", "可以在X标记点宝箱找到。", {34, 0, 0, 0, 50, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_trident_click(sender As Object, e As RoutedEventArgs) Handles button_G_trident.Click
        G_Show_E("三叉戟", "Trident", "G_trident", "SW", 0, 1, 0, "", "", "", "", "在深海区域用拖网有可能找到三叉戟，在陆地上只有34点攻击，在船上有三倍攻击加成。", {34, 0, 0, 0, 150, 0, 0, 0, 0, 0, 0})
    End Sub

    Private Sub button_G_seashell_suit_click(sender As Object, e As RoutedEventArgs) Handles button_G_seashell_suit.Click
        G_Show_E("海贝盔甲", "Seashell Suit", "S_seashell_suit", "SW", 0, 1, 0, "免疫中毒", "", "", "", "防御力还行，特点是免疫毒。", {0, 0, 0, 75, 0, 0, 0, 750, 0, 0, 0})
    End Sub

    Private Sub button_G_limestone_suit_click(sender As Object, e As RoutedEventArgs) Handles button_G_limestone_suit.Click
        G_Show_E("石灰石盔甲", "Limestone Suit", "S_limestone_suit", "SW", 0, 1, 0, "减速10%", "", "", "", "防御不错，但是会减速10%。", {0, 0, 0, 70, 0, 0, 0, 825, 0, 0, 2})
    End Sub

    Private Sub button_G_cactus_armour_click(sender As Object, e As RoutedEventArgs) Handles button_G_cactus_armour.Click
        G_Show_E("象仙人掌盔甲", "Cactus Armour", "S_cactus_armour", "SW", 0, 1, 0, "对攻击者造成17点伤害", "", "", "", "反伤神器。", {0, 0, 0, 80, 0, 0, 0, 450, 0, 0, 3.33})
    End Sub

    Private Sub button_G_horned_helmet_click(sender As Object, e As RoutedEventArgs) Handles button_G_horned_helmet.Click
        G_Show_E("角状头盔", "Horned Helmet", "S_horned_helmet", "SW", 0, 1, 0, "免疫中毒", "", "", "", "防御不错而且免疫毒。", {0, 0, 0, 85, 0, 0, 0, 600, 35, 0, 0})
    End Sub

    Private Sub button_G_obsidian_armour_click(sender As Object, e As RoutedEventArgs) Handles button_G_obsidian_armour.Click
        G_Show_E("黑曜石盔甲", "Obsidian Armour", "S_obsidian_armour", "SW", 0, 1, 0, "", "", "", "", "耐久只有鳞甲的四分之三，免疫火，并且攻击你的敌人会燃烧，防御力也一般。", {0, 0, 0, 70, 0, 0, 0, 1350, 0, 0, 0})
    End Sub

    Private Sub button_G_portable_crock_pot_click(sender As Object, e As RoutedEventArgs) Handles button_G_portable_crock_pot.Click
        G_Show_E("便携式烹饪锅", "Portable Crock Pot", "G_portable_crock_pot", "SW", 0, 1, 0, "沃利专属，可以额外制作四种食谱", "可移动", "", "", "在潮水中会失效。", {0, 0, 0, 0, 0, 1000, 0, 0, 0, 0, 0})
    End Sub
#End Region

#Region "物品_树苗"

    Private Sub button_G_bamboo_root_click(sender As Object, e As RoutedEventArgs) Handles button_G_bamboo_root.Click
        G_Show_S("竹根", "Bamboo Root", "G_bamboo_root", "SW", 0, 1, 0, "挖取竹子获得。", {"N_bamboo_patch"})
    End Sub

    Private Sub button_G_grass_tuft_SW_click(sender As Object, e As RoutedEventArgs) Handles button_G_grass_tuft_SW.Click
        G_Show_S("船难长草簇", "Grass Tuft", "G_grass_tuft_SW", "SW", 0, 1, 0, "挖取草获得。", {"N_grass_sw"})
    End Sub

    Private Sub button_G_coconut_click(sender As Object, e As RoutedEventArgs) Handles button_G_coconut.Click
        G_Show_S("椰子", "Coconut", "F_coconut", "SW", 0, 1, 0, "砍伐椰子树获得。", {"N_palm_tree_1"})
    End Sub

    Private Sub button_G_jungle_tree_seed_click(sender As Object, e As RoutedEventArgs) Handles button_G_jungle_tree_seed.Click
        G_Show_S("丛林树种", "Jungle Tree Seed", "G_jungle_tree_seed", "SW", 0, 1, 0, "砍伐丛林树获得。", {"N_jungle_tree_1"})
    End Sub

    Private Sub button_G_viney_bush_root_click(sender As Object, e As RoutedEventArgs) Handles button_G_viney_bush_root.Click
        G_Show_S("藤蔓根", "Viney Bush Root", "G_viney_bush_root", "SW", 0, 1, 0, "挖取藤蔓丛获得。", {"N_viney_bush"})
    End Sub

    Private Sub button_G_coffee_plant_click(sender As Object, e As RoutedEventArgs) Handles button_G_coffee_plant.Click
        G_Show_S("咖啡树", "Coffee Plant", "G_coffee_plant", "SW", 0, 1, 0, "挖取咖啡树获得。", {"N_coffee_plant"})
    End Sub

    Private Sub button_G_elephant_cactus_stump_click(sender As Object, e As RoutedEventArgs) Handles button_G_elephant_cactus_stump.Click
        G_Show_S("象仙人掌根", "Elephant Cactus Stump", "G_elephant_cactus_stump", "SW", 0, 1, 0, "挖取象仙人掌获得。", {"N_elephant_cactus"})
    End Sub
#End Region

#Region "物品_生物"
    Private Sub button_G_crabbit_click(sender As Object, e As RoutedEventArgs) Handles button_G_crabbit.Click
        G_Show_A("兔蟹", "Crabbit", "A_crabbit", "SW", 0, 1, 0, "", "", {"F_fish_morsel", "1"})
    End Sub

    Private Sub button_G_beardling_sw_click(sender As Object, e As RoutedEventArgs) Handles button_G_beardling_sw.Click
        G_Show_A("黑兔蟹", "Crabbit", "A_beardling_sw", "SW", 0, 1, 0, "", "", {"F_monster_meat", "1(40%)", "G_nightmare_fuel", "1(40%)", "G_beard_hair", "1(20%)"})
    End Sub

    Private Sub button_G_dead_dogfish_click(sender As Object, e As RoutedEventArgs) Handles button_G_dead_dogfish.Click
        G_Show_A("死狗鱼", "Dead Dogfish", "F_dead_dogfish", "SW", 0, 1, 0, "F_dead_dogfish", "", {})
    End Sub

    Private Sub button_G_dead_swordfish_click(sender As Object, e As RoutedEventArgs) Handles button_G_dead_swordfish.Click
        G_Show_A("死旗鱼", "Dead Swordfish", "F_dead_swordfish", "SW", 0, 1, 0, "F_dead_swordfish", "", {})
    End Sub

    Private Sub button_G_dead_wobster_click(sender As Object, e As RoutedEventArgs) Handles button_G_dead_wobster.Click
        G_Show_A("死龙虾", "Dead Wobster", "F_dead_wobster", "SW", 0, 1, 0, "F_dead_wobster", "", {})
    End Sub

    Private Sub button_G_bioluminescence_click(sender As Object, e As RoutedEventArgs) Handles button_G_bioluminescence.Click
        G_Show_A("海洋生物", "Bioluminescence", "G_bioluminescence", "SW", 0, 1, 0, "", "可以重新释放以获得微量的光。", {})
    End Sub

    Private Sub button_G_jellyfish_click(sender As Object, e As RoutedEventArgs) Handles button_G_jellyfish.Click
        G_Show_A("水母", "Jellyfish", "F_jellyfish", "SW", 0, 1, 0, "F_jellyfish", "", {})
    End Sub

    Private Sub button_G_dead_jellyfish_click(sender As Object, e As RoutedEventArgs) Handles button_G_dead_jellyfish.Click
        G_Show_A("死水母", "Dead jellyfish", "F_dead_jellyfish", "SW", 0, 1, 0, "F_dead_jellyfish", "", {})
    End Sub

    Private Sub button_G_butterfly_sw_click(sender As Object, e As RoutedEventArgs) Handles button_G_butterfly_sw.Click
        G_Show_A("船难蝴蝶", "Butterfly", "A_butterfly_sw", "SW", 0, 1, 0, "", "", {"F_butterfly_wing_sw", "1(98%)", "F_butter", "1(2%)"})
    End Sub

    Private Sub button_G_mosquito_sw_click(sender As Object, e As RoutedEventArgs) Handles button_G_mosquito_sw.Click
        G_Show_A("毒蚊子", "Poison Mosquito", "A_mosquito_sw", "SW", 0, 1, 0, "", "", {"G_yellow_mosquito_sack", "1(50%)"})
    End Sub

    Private Sub button_G_parrot_click(sender As Object, e As RoutedEventArgs) Handles button_G_parrot.Click
        G_Show_A("鹦鹉", "Parrot", "A_parrot", "SW", 0, 1, 0, "", "可以囚禁在鸟笼里。", {"F_morsel", "1(50%)", "G_crimson_feather", "1(50%)"})
    End Sub

    Private Sub button_G_parrot_pirate_click(sender As Object, e As RoutedEventArgs) Handles button_G_parrot_pirate.Click
        G_Show_A("海盗鹦鹉", "Parrot Pirate", "A_parrot_pirate", "SW", 0, 1, 0, "", "可以囚禁在鸟笼里。", {"F_morsel", "1(50%)", "G_crimson_feather", "1(50%)"})
    End Sub

    Private Sub button_G_toucan_click(sender As Object, e As RoutedEventArgs) Handles button_G_toucan.Click
        G_Show_A("大嘴鸟", "Toucan", "A_toucan", "SW", 0, 1, 0, "", "可以囚禁在鸟笼里。", {"F_morsel", "1(50%)", "G_jet_feather", "1(50%)"})
    End Sub

    Private Sub button_G_seagull_click(sender As Object, e As RoutedEventArgs) Handles button_G_seagull.Click
        G_Show_A("海鸥", "Seagull", "A_seagull", "SW", 0, 1, 0, "", "可以囚禁在鸟笼里。", {"F_morsel", "1(50%)", "G_azure_feather", "1(50%)"})
    End Sub
#End Region

#Region "物品_草皮"

    Private Sub button_G_jungle_turf_click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_jungle_turf.Click
        G_Show_T("丛林草皮", "Jungle Turf", "G_jungle_turf", "SW", 0, 1, 0, "Texture_jungle_turf", "出现在热带雨林区域，可以在上面种植植物，也不阻止食人花和眼球草的生长，当铺设的丛林草皮足够大时，附近只会出现鹦鹉、海盗鹦鹉和海鸥。")
    End Sub

    Private Sub button_G_meadow_turf_click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_meadow_turf.Click
        G_Show_T("草甸草皮", "Meadow Turf", "G_meadow_turf", "SW", 0, 1, 0, "Texture_meadow_turf", "出现在草甸区域，可以在上面种植植物，也不阻止食人花和眼球草的生长，当铺设的草甸草皮足够大时，附近只会出现大嘴鸟。")
    End Sub

    Private Sub button_G_tidal_marsh_turf_click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_tidal_marsh_turf.Click
        G_Show_T("潮滩地皮", "Tidal Marsh", "G_tidal_marsh_turf", "SW", 0, 1, 0, "Texture_tidal_marsh_turf", "出现在潮汐沼泽区域，可以在上面种植植物，也不阻止食人花和眼球草的生长，当铺设的潮滩地皮足够大时，附近只会出现大嘴鸟。")
    End Sub

    Private Sub button_G_magma_turf_click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_magma_turf.Click
        G_Show_T("岩浆地皮", "Magma Turf", "G_magma_turf", "SW", 0, 1, 0, "Texture_magma_turf", "出现在岩浆领域区域，不能在上面种植植物，但是可以种植食人花(眼球草不会生长)和咖啡树，当铺设的岩浆地皮足够大时，附近只会出现大嘴鸟。")
    End Sub

    Private Sub button_G_ashy_turf_click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_ashy_turf.Click
        G_Show_T("灰色地皮", "Ashy Turf", "G_ashy_turf", "SW", 0, 1, 0, "Texture_ashy_turf", "出现在火山区域，不能在上面种植植物，但是可以种植食人花(眼球草不会生长)，当铺设的灰色地皮足够大时，附近只会出现大嘴鸟。")
    End Sub

    Private Sub button_G_volcano_turf_click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_volcano_turf.Click
        G_Show_T("火山地皮", "Volcano Turf", "G_volcano_turf", "SW", 0, 1, 0, "Texture_volcano_turf", "出现在火山区域，不能在上面种植植物，但是可以种植食人花(眼球草不会生长)、咖啡树和象仙人掌，当铺设的火山地皮足够大时，附近只会出现大嘴鸟。")
    End Sub

    Private Sub button_G_beach_turf_click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_beach_turf.Click
        G_Show_T("海滩地皮", "Beach Turf", "G_beach_turf", "SW", 0, 1, 0, "Texture_beach_turf", "不可以挖出(可以用控制台调出)！出现在海滩区域，可以在上面种植植物，也不阻止食人花和眼球草的生长。")
    End Sub
#End Region

#Region "物品_宠物"
    Private Sub button_GP_Switch_Left_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GP_Switch_Left.Click
        button_GP_Switch_Right.IsEnabled = True
        If G_PetListIndex <> 0 Then
            G_PetListIndex -= 1
            If G_PetListIndex = 0 Then
                button_GP_Switch_Left.IsEnabled = False
            End If
            Select Case G_PetList(G_PetListIndex)
                Case "chester"
                    G_Show_P("切斯特眼骨", "Eye Bone", "G_eye_bone", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_chester"})
                Case "chester_dead"
                    G_Show_P("切斯特眼骨(死亡)", "Eye Bone", "G_eye_bone_died", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_chester"})
                Case "chester_snow"
                    G_Show_P("寒冰切斯特眼骨", "Eye Bone", "G_eye_bone_snow", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_snow_chester"})
                Case "chester_snow_dead"
                    G_Show_P("寒冰切斯特眼骨(死亡)", "Eye Bone", "G_eye_bone_died_snow", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_snow_chester"})
                Case "chester_shadow"
                    G_Show_P("暗影切斯特眼骨", "Eye Bone", "G_eye_bone_shadow", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_shadow_chester"})
                Case "chester_shadow_dead"
                    G_Show_P("暗影切斯特眼骨(死亡)", "Eye Bone", "G_eye_bone_died_shadow", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_shadow_chester"})
                Case "packim_baggims"
                    G_Show_P("鱼骨", "Fishbone", "G_fishbone", "SW", 0, 1, 0, "鱼骨有可能出现在除了起始岛的任意岛上，是船难版的眼骨，会召唤鹈鹕，不会沉入水中。", {"A_packim_baggims", "A_fat_packim_baggims", "A_fire_packim_baggims"})
                Case "packim_baggims_dead"
                    G_Show_P("鱼骨(死亡)", "Fishbone", "G_fishbone_died", "SW", 0, 1, 0, "鱼骨有可能出现在除了起始岛的任意岛上，是船难版的眼骨，会召唤鹈鹕，不会沉入水中。", {"A_packim_baggims", "A_fat_packim_baggims", "A_fire_packim_baggims"})
                Case "hutch"
                    G_Show_P("星-空", "Star-Sky", "G_star_sky", "DST", 0, 0, 1, "星-空是联机版的眼骨，只在洞穴里，会召唤哈奇。", {"A_hutch", "A_fugu_hutch", "A_music_box_hutch"})
                Case "hutch_dead"
                    G_Show_P("星-空(死亡)", "Star-Sky", "G_star_sky_died", "DST", 0, 0, 1, "星-空是联机版的眼骨，只在洞穴里，会召唤哈奇。", {"A_hutch", "A_fugu_hutch", "A_music_box_hutch"})
            End Select
        End If
    End Sub

    Private Sub button_GP_Switch_Right_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GP_Switch_Right.Click
        button_GP_Switch_Left.IsEnabled = True
        If G_PetListIndex <> G_PetListIndexMax Then
            G_PetListIndex += 1
            If G_PetListIndex = G_PetListIndexMax Then
                button_GP_Switch_Right.IsEnabled = False
            End If
            Select Case G_PetList(G_PetListIndex)
                Case "chester"
                    G_Show_P("切斯特眼骨", "Eye Bone", "G_eye_bone", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_chester"})
                Case "chester_dead"
                    G_Show_P("切斯特眼骨(死亡)", "Eye Bone", "G_eye_bone_died", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_chester"})
                Case "chester_snow"
                    G_Show_P("寒冰切斯特眼骨", "Eye Bone", "G_eye_bone_snow", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_snow_chester"})
                Case "chester_snow_dead"
                    G_Show_P("寒冰切斯特眼骨(死亡)", "Eye Bone", "G_eye_bone_died_snow", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_snow_chester"})
                Case "chester_shadow"
                    G_Show_P("暗影切斯特眼骨", "Eye Bone", "G_eye_bone_shadow", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_shadow_chester"})
                Case "chester_shadow_dead"
                    G_Show_P("暗影切斯特眼骨(死亡)", "Eye Bone", "G_eye_bone_died_shadow", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_shadow_chester"})
                Case "packim_baggims"
                    G_Show_P("鱼骨", "Fishbone", "G_fishbone", "SW", 0, 1, 0, "鱼骨有可能出现在除了起始岛的任意岛上，是船难版的眼骨，会召唤鹈鹕，不会沉入水中。", {"A_packim_baggims", "A_fat_packim_baggims", "A_fire_packim_baggims"})
                Case "packim_baggims_dead"
                    G_Show_P("鱼骨(死亡)", "Fishbone", "G_fishbone_died", "SW", 0, 1, 0, "鱼骨有可能出现在除了起始岛的任意岛上，是船难版的眼骨，会召唤鹈鹕，不会沉入水中。", {"A_packim_baggims", "A_fat_packim_baggims", "A_fire_packim_baggims"})
                Case "hutch"
                    G_Show_P("星-空", "Star-Sky", "G_star_sky", "DST", 0, 0, 1, "星-空是联机版的眼骨，只在洞穴里，会召唤哈奇。", {"A_hutch", "A_fugu_hutch", "A_music_box_hutch"})
                Case "hutch_dead"
                    G_Show_P("星-空(死亡)", "Star-Sky", "G_star_sky_died", "DST", 0, 0, 1, "星-空是联机版的眼骨，只在洞穴里，会召唤哈奇。", {"A_hutch", "A_fugu_hutch", "A_music_box_hutch"})
            End Select
        End If
    End Sub

    Private Sub button_GP_Switch_initialization()
        button_GP_Switch_Left.Visibility = Visibility.Visible
        button_GP_Switch_Right.Visibility = Visibility.Visible
        button_GP_Switch_Left.IsEnabled = False
        button_GP_Switch_Right.IsEnabled = True
        ReDim G_PetList(1)
        G_PetList(0) = ""
        G_PetListIndex = 0
        G_PetListIndexMax = -128
    End Sub

    Private Sub G_PetListAddPet(PetName As String)
        If G_PetListIndex >= G_PetListIndexMax Then
            G_PetListIndexMax = G_PetListIndex
            G_PetListIndex += 1
            ReDim Preserve G_PetList(G_PetListIndex)
            G_PetList(G_PetListIndex - 1) = PetName
        End If
    End Sub

    Private Sub button_G_eye_bone_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_eye_bone.Click
        button_GP_Switch_initialization()
        G_PetListAddPet("chester")
        G_PetListAddPet("chester_dead")
        G_PetListAddPet("chester_snow")
        G_PetListAddPet("chester_snow_dead")
        G_PetListAddPet("chester_shadow")
        G_PetListAddPet("chester_shadow_dead")
        G_PetListIndex = 0
        G_Show_P("切斯特眼骨", "Eye Bone", "G_eye_bone", "NoDLC", 1, 0, 1, "通常可以在卵石路的尽头找到，也有可能在沼泽附近。眼骨可以召唤切斯特并让切斯特跟随，放在地上或切斯特里会使切斯特停止跟随。切斯特死亡后眼骨将闭眼，一天后切斯特重生。", {"A_chester"})
    End Sub

    Private Sub button_G_fishbone_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_fishbone.Click
        button_GP_Switch_initialization()
        G_PetListAddPet("packim_baggims")
        G_PetListAddPet("packim_baggims_dead")
        G_PetListIndex = 0
        G_Show_P("鱼骨", "Fishbone", "G_fishbone", "SW", 0, 1, 0, "鱼骨有可能出现在除了起始岛的任意岛上，是船难版的眼骨，会召唤鹈鹕，不会沉入水中。", {"A_packim_baggims", "A_fat_packim_baggims", "A_fire_packim_baggims"})
    End Sub

    Private Sub button_G_lavae_egg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_lavae_egg.Click
        G_LeftPanel_Initialization()
        ScrollViewer_GoodsLeft_PetLavaeEgg.Visibility = Visibility.Visible
    End Sub

    Private Sub button_GP_SpawnButton_1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GP_SpawnButton_1.Click
        button_G_lavae_tooth_Click(Nothing, Nothing)
    End Sub

    Private Sub button_GP_SpawnButton_2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GP_SpawnButton_2.Click
        LeftTabItem_Animal.IsSelected = True
        button_A_Extra_Adorable_Lavae_click(Nothing, Nothing)
    End Sub

    Private Sub button_G_lavae_tooth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_lavae_tooth.Click
        G_Show_P("熔岩虫牙", "Lavae Tooth", "G_lavae_tooth", "DST", 0, 0, 1, "熔岩虫卵孵化后会产生熔岩虫牙和一只超可爱的熔岩虫，超可爱的熔岩虫会跟随熔岩虫牙，当超可爱的熔岩虫死后熔岩虫牙化为灰烬。", {"A_lavae"})
        button_GP_Switch_Left.Visibility = Visibility.Collapsed
        button_GP_Switch_Right.Visibility = Visibility.Collapsed
    End Sub

    Private Sub button_G_star_sky_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_star_sky.Click
        button_GP_Switch_initialization()
        G_PetListAddPet("hutch")
        G_PetListAddPet("hutch_dead")
        G_PetListIndex = 0
        G_Show_P("星-空", "Star-Sky", "G_star_sky", "DST", 0, 0, 1, "星-空是联机版的眼骨，只在洞穴里，会召唤哈奇。", {"A_hutch", "A_fugu_hutch", "A_music_box_hutch"})
    End Sub
#End Region

#Region "物品_解锁"
    REM ------------------左侧面板(物品_解锁)------------------
    Private Sub G_Show_U(G_Name As String, G_EnName As String, G_picture As String, G_DLC As String, G_DLC_ROG As SByte, G_DLC_SW As SByte, G_DLC_DST As SByte, G_UnlockCharacter As String, G_Introduce As String, ParamArray Drop() As String)
        REM ------------------初始化------------------
        G_LeftPanel_Initialization()
        ScrollViewer_GoodsLeft_Unlock.Visibility = Visibility.Visible
        button_GU_Drop_2.Visibility = Visibility.Collapsed
        button_GU_Drop_3.Visibility = Visibility.Collapsed
        button_GU_Drop_4.Visibility = Visibility.Collapsed
        button_GU_Drop_5.Visibility = Visibility.Collapsed
        button_GU_Drop_6.Visibility = Visibility.Collapsed
        button_GU_Drop_7.Visibility = Visibility.Collapsed
        button_GU_Drop_8.Visibility = Visibility.Collapsed
        REM ------------------物品名字------------------
        GL_textBlock_GoodsName_U.Text = G_Name
        GL_textBlock_GoodsName_U.UpdateLayout()
        Dim G_N_MarginLeft As Integer
        G_N_MarginLeft = (Canvas_GoodsLeft_U.ActualWidth - GL_textBlock_GoodsName_U.ActualWidth) / 2
        Dim G_N_T As New Thickness()
        G_N_T.Top = 80
        G_N_T.Left = G_N_MarginLeft
        GL_textBlock_GoodsName_U.Margin = G_N_T

        GL_textBlock_GoodsEnName_U.Text = G_EnName
        GL_textBlock_GoodsEnName_U.UpdateLayout()
        Dim G_EnN_MarginLeft As Integer
        G_EnN_MarginLeft = (Canvas_GoodsLeft_U.ActualWidth - GL_textBlock_GoodsEnName_U.ActualWidth) / 2
        Dim G_EnN_T As New Thickness()
        G_EnN_T.Top = 100
        G_EnN_T.Left = G_EnN_MarginLeft
        GL_textBlock_GoodsEnName_U.Margin = G_EnN_T
        REM ------------------物品图片------------------
        GL_image_GoodsPicture_U.Source = Picture_Short_Name(Res_Short_Name(G_picture))
        REM ------------------物品DLC-------------------
        If G_DLC = "ROG" Then
            GL_image_GU_DLC.Source = Picture_Short_Name(Res_Short_Name("DLC_ROG"))
        ElseIf G_DLC = "SW" Then
            GL_image_GU_DLC.Source = Picture_Short_Name(Res_Short_Name("DLC_SW"))
        ElseIf G_DLC = "DST" Then
            GL_image_GU_DLC.Source = Picture_Short_Name(Res_Short_Name("DLC_DST"))
        Else
            GL_image_GU_DLC.Source = Picture_Short_Name()
        End If
        REM ------------------存在版本-------------------
        GL_textBlock_GU_DLC_1.Foreground = Brushes.Black
        GL_textBlock_GU_DLC_2.Foreground = Brushes.Black
        GL_textBlock_GU_DLC_3.Foreground = Brushes.Black
        If G_DLC_ROG = 0 Then
            GL_textBlock_GU_DLC_1.Foreground = Brushes.Silver
        End If
        If G_DLC_SW = 0 Then
            GL_textBlock_GU_DLC_2.Foreground = Brushes.Silver
        End If
        If G_DLC_DST = 0 Then
            GL_textBlock_GU_DLC_3.Foreground = Brushes.Silver
        End If
        REM --------------------掉落---------------------
        Dim DL As Byte
        DL = Drop.Length
        Select Case DL
            Case 1
                image_GU_Drop_1.Source = Picture_Short_Name(Res_Short_Name(Drop(0)))
                G_WrapPanel_DropButton_U.Height = 60
            Case 2
                GS_UnlockDrop_Select_2 = Drop(1)
                button_GU_Drop_2.Visibility = Visibility.Visible
                image_GU_Drop_1.Source = Picture_Short_Name(Res_Short_Name(Drop(0)))
                image_GU_Drop_2.Source = Picture_Short_Name(Res_Short_Name(Drop(1)))
                G_WrapPanel_DropButton_U.Height = 60
            Case 8
                GS_UnlockDrop_Select_2 = Drop(1)
                button_GU_Drop_2.Visibility = Visibility.Visible
                button_GU_Drop_3.Visibility = Visibility.Visible
                button_GU_Drop_4.Visibility = Visibility.Visible
                button_GU_Drop_5.Visibility = Visibility.Visible
                button_GU_Drop_6.Visibility = Visibility.Visible
                button_GU_Drop_7.Visibility = Visibility.Visible
                button_GU_Drop_8.Visibility = Visibility.Visible
                image_GU_Drop_1.Source = Picture_Short_Name(Res_Short_Name(Drop(0)))
                image_GU_Drop_2.Source = Picture_Short_Name(Res_Short_Name(Drop(1)))
                image_GU_Drop_3.Source = Picture_Short_Name(Res_Short_Name(Drop(2)))
                image_GU_Drop_4.Source = Picture_Short_Name(Res_Short_Name(Drop(3)))
                image_GU_Drop_5.Source = Picture_Short_Name(Res_Short_Name(Drop(4)))
                image_GU_Drop_6.Source = Picture_Short_Name(Res_Short_Name(Drop(5)))
                image_GU_Drop_7.Source = Picture_Short_Name(Res_Short_Name(Drop(6)))
                image_GU_Drop_8.Source = Picture_Short_Name(Res_Short_Name(Drop(7)))
                G_WrapPanel_DropButton_U.Height = 160
        End Select
        GS_UnlockDrop_Select_1 = Drop(0)
        REM ------------------解锁人物-------------------
        GS_UnlockCharacter_Select = G_UnlockCharacter
        image_GU_UnlockCharacter.Source = Picture_Short_Name(Res_Short_Name(G_UnlockCharacter))
        REM ------------------物品简介-------------------
        TextBlock_GU_Introduce.Text = G_Introduce
        G_WrapPanel_Introduce_U.Height = ReturnTextBlockHeight(Canvas_GoodsLeft_U, TextBlock_GU_Introduce)
    End Sub

    Private Sub button_GU_UnlockCharacter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GU_UnlockCharacter.Click
        ButtonJump(GS_UnlockCharacter_Select)
    End Sub

    Private Sub button_GU_Drop_1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GU_Drop_1.Click
        ButtonJump(GS_UnlockDrop_Select_1)
    End Sub

    Private Sub button_GU_Drop_2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GU_Drop_2.Click
        ButtonJump(GS_UnlockDrop_Select_2)
    End Sub

    Private Sub button_GU_Drop_3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GU_Drop_3.Click
        ButtonJump(GS_UnlockDrop_Select_3)
    End Sub

    Private Sub button_GU_Drop_4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GU_Drop_4.Click
        ButtonJump(GS_UnlockDrop_Select_4)
    End Sub

    Private Sub button_GU_Drop_5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GU_Drop_5.Click
        ButtonJump(GS_UnlockDrop_Select_5)
    End Sub

    Private Sub button_GU_Drop_6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GU_Drop_6.Click
        ButtonJump(GS_UnlockDrop_Select_6)
    End Sub

    Private Sub button_GU_Drop_7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GU_Drop_7.Click
        ButtonJump(GS_UnlockDrop_Select_7)
    End Sub

    Private Sub button_GU_Drop_8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GU_Drop_8.Click
        ButtonJump(GS_UnlockDrop_Select_8)
    End Sub

    Private Sub button_G_webbers_skull_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_webbers_skull.Click
        G_Show_U("维伯的头颅", "Webbers Skull", "G_webber's_skull", "ROG", 1, 0, 0, "C_webber", "每次击杀任何蜘蛛或拆蜘蛛巢和蛛网岩都有5%的几率掉落维伯的头颅，把维伯的头颅放进挖开的坟墓中，坟墓会被闪电劈中，维伯会出现，然后跳回坟墓消失，并出现6只蜘蛛，维伯就解锁了(不需要杀死蜘蛛)。", {"A_spider", "A_spider_warrior", "A_spitter", "A_cave_spider", "A_dangling_depth_dweller", "A_spider_queen", "N_spider_den", "N_spilagmite"})
    End Sub

    Private Sub button_G_iron_key_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_iron_key.Click
        G_Show_U("铁制钥匙", "Iron Key", "G_iron_key", "SW", 0, 1, 0, "C_woodlegs", "第一次击杀呱肯乌贼就会获得骨制钥匙。集齐三把钥匙即可解锁火山里的伍德莱格。", {"A_quacken"})
    End Sub

    Private Sub button_G_golden_key_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_golden_key.Click
        G_Show_U("金制钥匙", "Golden Key", "G_golden_key", "SW", 0, 1, 0, "C_woodlegs", "与亚克章鱼交易有10%的几率获得金制钥匙。集齐三把钥匙即可解锁火山里的伍德莱格。", {"A_yaarctopus"})
    End Sub

    Private Sub button_G_bone_key_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_bone_key.Click
        G_Show_U("骨制钥匙", "Bone Key", "G_bone_key", "SW", 0, 1, 0, "C_woodlegs", "在潮湿的坟墓钓鱼有几率获得铁制钥匙，每次钓鱼都会增加获得的几率。集齐三把钥匙即可解锁火山里的伍德莱格。", {"N_watery_grave"})
    End Sub

    Private Sub button_G_tarnished_crown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_tarnished_crown.Click
        G_Show_U("旧王冠", "Tarnished Crown", "G_tarnished_crown", "SW", 0, 1, 0, "C_wilbur", "每次击杀猿猴或摧毁猿猴小屋都有10%的几率掉落旧王冠，把旧王冠给在浅海的竹筏上的威尔伯即可解锁威尔伯人物。", {"A_prime_ape", "N_Prime_ape_hut"})
    End Sub
#End Region

#Region "物品_零件"
    REM ------------------左侧面板(物品_零件)------------------
    Private Sub G_Show_C(G_Name As String, G_EnName As String, G_picture As String, G_DLC As String, G_DLC_ROG As SByte, G_DLC_SW As SByte, G_DLC_DST As SByte, G_Introduce As String)
        REM ------------------初始化------------------
        G_LeftPanel_Initialization()
        ScrollViewer_GoodsLeft_Component.Visibility = Visibility.Visible
        REM ------------------物品名字------------------
        GL_textBlock_GoodsName_C.Text = G_Name
        GL_textBlock_GoodsName_C.UpdateLayout()
        Dim G_N_MarginLeft As Integer
        G_N_MarginLeft = (Canvas_GoodsLeft_C.ActualWidth - GL_textBlock_GoodsName_C.ActualWidth) / 2
        Dim G_N_T As New Thickness()
        G_N_T.Top = 80
        G_N_T.Left = G_N_MarginLeft
        GL_textBlock_GoodsName_C.Margin = G_N_T

        GL_textBlock_GoodsEnName_C.Text = G_EnName
        GL_textBlock_GoodsEnName_C.UpdateLayout()
        Dim G_EnN_MarginLeft As Integer
        G_EnN_MarginLeft = (Canvas_GoodsLeft_C.ActualWidth - GL_textBlock_GoodsEnName_C.ActualWidth) / 2
        Dim G_EnN_T As New Thickness()
        G_EnN_T.Top = 100
        G_EnN_T.Left = G_EnN_MarginLeft
        GL_textBlock_GoodsEnName_C.Margin = G_EnN_T
        REM ------------------物品图片------------------
        GL_image_GoodsPicture_C.Source = Picture_Short_Name(Res_Short_Name(G_picture))
        REM ------------------物品DLC-------------------
        If G_DLC = "ROG" Then
            GL_image_GC_DLC.Source = Picture_Short_Name(Res_Short_Name("DLC_ROG"))
        ElseIf G_DLC = "SW" Then
            GL_image_GC_DLC.Source = Picture_Short_Name(Res_Short_Name("DLC_SW"))
        ElseIf G_DLC = "DST" Then
            GL_image_GC_DLC.Source = Picture_Short_Name(Res_Short_Name("DLC_DST"))
        Else
            GL_image_GC_DLC.Source = Picture_Short_Name()
        End If
        REM ------------------存在版本-------------------
        GL_textBlock_GC_DLC_1.Foreground = Brushes.Black
        GL_textBlock_GC_DLC_2.Foreground = Brushes.Black
        GL_textBlock_GC_DLC_3.Foreground = Brushes.Black
        If G_DLC_ROG = 0 Then
            GL_textBlock_GC_DLC_1.Foreground = Brushes.Silver
        End If
        If G_DLC_SW = 0 Then
            GL_textBlock_GC_DLC_2.Foreground = Brushes.Silver
        End If
        If G_DLC_DST = 0 Then
            GL_textBlock_GC_DLC_3.Foreground = Brushes.Silver
        End If
        REM ------------------物品简介-------------------
        TextBlock_GC_Introduce.Text = G_Introduce
        G_WrapPanel_Introduce_C.Height = ReturnTextBlockHeight(Canvas_GoodsLeft_C, TextBlock_GC_Introduce)
    End Sub

    Private Sub button_GC_Switch_Left_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GC_Switch_Left.Click
        button_GC_Switch_Right.IsEnabled = True
        If G_ComponentListIndex <> 0 Then
            G_ComponentListIndex -= 1
            If G_ComponentListIndex = 0 Then
                button_GC_Switch_Left.IsEnabled = False
            End If
            Select Case G_ComponentList(G_ComponentListIndex)
                Case "Boxthing"
                    G_Show_C("盒状传送机零件", "Box Thing", "G_box_thing_1", "ROG", 1, 0, 0, "盒状传送机零件是用来制作传送机的四个零件之一。")
                Case "BoxthingAdvanture"
                    G_Show_C("盒状传送机零件(冒险模式)", "Box Thing", "G_box_thing_2", "ROG", 1, 0, 0, "盒状传送机零件是用来制作传送机的四个零件之一。")
                Case "Crankthing"
                    G_Show_C("曲柄状传送机零件", "Crank Thing", "G_crank_thing_1", "ROG", 1, 0, 0, "曲柄状送机零件是用来制作传送机的四个零件之一。")
                Case "CrankthingAdvanture"
                    G_Show_C("曲柄状传送机零件(冒险模式)", "Crank Thing", "G_crank_thing_2", "ROG", 1, 0, 0, "曲柄状送机零件是用来制作传送机的四个零件之一。")
                Case "Metalpotatothing"
                    G_Show_C("球状传送机零件", "Metal Potato Thing", "G_metal_potato_thing_1", "ROG", 1, 0, 0, "球状传送机零件是用来制作传送机的四个零件之一。")
                Case "MetalpotatothingAdvanture"
                    G_Show_C("球状传送机零件(冒险模式)", "Metal Potato Thing", "G_metal_potato_thing_2", "ROG", 1, 0, 0, "球状传送机零件是用来制作传送机的四个零件之一。")
                Case "Ringthing"
                    G_Show_C("环状传送机零件", "Ring Thing", "G_ring_thing_1", "ROG", 1, 0, 0, "环状传送机零件是用来制作传送机的四个零件之一。")
                Case "RingthingAdvanture"
                    G_Show_C("环状传送机零件(冒险模式)", "Ring Thing", "G_ring_thing_2", "ROG", 1, 0, 0, "环状传送机零件是用来制作传送机的四个零件之一。")
            End Select
        End If
    End Sub

    Private Sub button_GC_Switch_Right_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GC_Switch_Right.Click
        button_GC_Switch_Left.IsEnabled = True
        If G_ComponentListIndex <> G_ComponentListIndexMax Then
            G_ComponentListIndex += 1
            If G_ComponentListIndex = G_ComponentListIndexMax Then
                button_GC_Switch_Right.IsEnabled = False
            End If
            Select Case G_ComponentList(G_ComponentListIndex)
                Case "Boxthing"
                    G_Show_C("盒状传送机零件", "Box Thing", "G_box_thing_1", "ROG", 1, 0, 0, "盒状传送机零件是用来制作传送机的四个零件之一。")
                Case "BoxthingAdvanture"
                    G_Show_C("盒状传送机零件(冒险模式)", "Box Thing", "G_box_thing_2", "ROG", 1, 0, 0, "盒状传送机零件是用来制作传送机的四个零件之一。")
                Case "Crankthing"
                    G_Show_C("曲柄状传送机零件", "Crank Thing", "G_crank_thing_1", "ROG", 1, 0, 0, "曲柄状送机零件是用来制作传送机的四个零件之一。")
                Case "CrankthingAdvanture"
                    G_Show_C("曲柄状传送机零件(冒险模式)", "Crank Thing", "G_crank_thing_2", "ROG", 1, 0, 0, "曲柄状送机零件是用来制作传送机的四个零件之一。")
                Case "Metalpotatothing"
                    G_Show_C("球状传送机零件", "Metal Potato Thing", "G_metal_potato_thing_1", "ROG", 1, 0, 0, "球状传送机零件是用来制作传送机的四个零件之一。")
                Case "MetalpotatothingAdvanture"
                    G_Show_C("球状传送机零件(冒险模式)", "Metal Potato Thing", "G_metal_potato_thing_2", "ROG", 1, 0, 0, "球状传送机零件是用来制作传送机的四个零件之一。")
                Case "Ringthing"
                    G_Show_C("环状传送机零件", "Ring Thing", "G_ring_thing_1", "ROG", 1, 0, 0, "环状传送机零件是用来制作传送机的四个零件之一。")
                Case "RingthingAdvanture"
                    G_Show_C("环状传送机零件(冒险模式)", "Ring Thing", "G_ring_thing_2", "ROG", 1, 0, 0, "环状传送机零件是用来制作传送机的四个零件之一。")
            End Select
        End If
    End Sub

    Private Sub button_GC_Switch_initialization()
        button_GC_Switch_Left.Visibility = Visibility.Visible
        button_GC_Switch_Right.Visibility = Visibility.Visible
        button_GC_Switch_Left.IsEnabled = False
        button_GC_Switch_Right.IsEnabled = True
        ReDim G_ComponentList(1)
        G_ComponentList(0) = ""
        G_ComponentListIndex = 0
        G_ComponentListIndexMax = -128
    End Sub

    Private Sub G_ComponentListAddComponent(ComponentName As String)
        If G_ComponentListIndex >= G_ComponentListIndexMax Then
            G_ComponentListIndexMax = G_ComponentListIndex
            G_ComponentListIndex += 1
            ReDim Preserve G_ComponentList(G_ComponentListIndex)
            G_ComponentList(G_ComponentListIndex - 1) = ComponentName
        End If
    End Sub

    Private Sub button_G_box_thing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_box_thing.Click
        button_GC_Switch_initialization()
        G_ComponentListAddComponent("Boxthing")
        G_ComponentListAddComponent("BoxthingAdvanture")
        G_ComponentListIndex = 0
        G_Show_C("盒状传送机零件", "Box Thing", "G_box_thing_1", "ROG", 1, 0, 0, "盒状传送机零件是用来制作传送机的四个零件之一。")
    End Sub

    Private Sub button_G_crank_thing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_crank_thing.Click
        button_GC_Switch_initialization()
        G_ComponentListAddComponent("Crankthing")
        G_ComponentListAddComponent("CrankthingAdvanture")
        G_ComponentListIndex = 0
        G_Show_C("曲柄状传送机零件", "Crank Thing", "G_crank_thing_1", "ROG", 1, 0, 0, "曲柄状传送机零件是用来制作传送机的四个零件之一。")
    End Sub

    Private Sub button_G_metal_potato_thing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_metal_potato_thing.Click
        button_GC_Switch_initialization()
        G_ComponentListAddComponent("Metalpotatothing")
        G_ComponentListAddComponent("MetalpotatothingAdvanture")
        G_ComponentListIndex = 0
        G_Show_C("球状传送机零件", "Metal Potato Thing", "G_metal_potato_thing_1", "ROG", 1, 0, 0, "球状传送机零件是用来制作传送机的四个零件之一。")
    End Sub

    Private Sub button_G_ring_thing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_ring_thing.Click
        button_GC_Switch_initialization()
        G_ComponentListAddComponent("Ringthing")
        G_ComponentListAddComponent("RingthingAdvanture")
        G_ComponentListIndex = 0
        G_Show_C("环状传送机零件", "Ring Thing", "G_ring_thing_1", "ROG", 1, 0, 0, "环状传送机零件是用来制作传送机的四个零件之一。")
    End Sub

    Private Sub button_G_grassy_thing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_grassy_thing.Click
        G_Show_C("长满草的玩意", "Grassy Thing", "G_grassy_thing", "SW", 0, 1, 0, "长满草的玩意是用来制作传送机的四个零件之一。")
        button_GC_Switch_Left.Visibility = Visibility.Collapsed
        button_GC_Switch_Right.Visibility = Visibility.Collapsed
    End Sub

    Private Sub button_G_ring_thing_sw_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_ring_thing_sw.Click
        G_Show_C("类似戒指的玩意", "Ring Thing", "G_ring_thing", "SW", 0, 1, 0, "类似戒指的玩意是用来制作传送机的四个零件之一。")
        button_GC_Switch_Left.Visibility = Visibility.Collapsed
        button_GC_Switch_Right.Visibility = Visibility.Collapsed
    End Sub

    Private Sub button_G_screw_thing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_screw_thing.Click
        G_Show_C("螺丝钉", "Screw Thing", "G_screw_thing", "SW", 0, 1, 0, "螺丝钉是用来制作传送机的四个零件之一。")
        button_GC_Switch_Left.Visibility = Visibility.Collapsed
        button_GC_Switch_Right.Visibility = Visibility.Collapsed
    End Sub

    Private Sub button_G_wooden_potato_thing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_wooden_potato_thing.Click
        G_Show_C("木质的类似土豆的玩意", "Wooden Potato Thing", "G_wooden_potato_thing", "SW", 0, 1, 0, "木质的类似土豆的玩意是用来制作传送机的四个零件之一。")
        button_GC_Switch_Left.Visibility = Visibility.Collapsed
        button_GC_Switch_Right.Visibility = Visibility.Collapsed
    End Sub
#End Region

#Region "物品_其他"
    REM ------------------左侧面板(物品_其他)------------------
    Private Sub button_G_blueprint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_blueprint.Click
        G_LeftPanel_Initialization()
        ScrollViewer_GoodsLeft_Blueprint.Visibility = Visibility.Visible
    End Sub

    Private Sub button_G_ballphin_free_tuna_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_ballphin_free_tuna.Click
        G_LeftPanel_Initialization()
        ScrollViewer_GoodsLeft_BallphinFreeTuna.Visibility = Visibility.Visible
    End Sub

    Private Sub button_GBFT_FoodButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_GBFT_FoodButton.Click
        ButtonJump("F_fish_steak")
    End Sub

    Private Sub button_G_message_in_a_bottle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_G_message_in_a_bottle.Click
        G_LeftPanel_Initialization()
        ScrollViewer_GoodsLeft_MessageInABottle.Visibility = Visibility.Visible
    End Sub
#End Region

#Region "物品_DLC"
    REM 物品DLC检测初始化
    Private Sub G_DLC_Check_initialization()
        REM 材料
        button_G_marble.Visibility = Visibility.Collapsed
        button_G_beefalo_horn.Visibility = Visibility.Collapsed
        button_G_guano.Visibility = Visibility.Collapsed
        button_G_glommers_flower.Visibility = Visibility.Collapsed
        button_G_mosquito_sack.Visibility = Visibility.Collapsed
        button_G_volt_goat_horn.Visibility = Visibility.Collapsed
        button_G_walrus_tusk.Visibility = Visibility.Collapsed
        button_G_light_bulb.Visibility = Visibility.Collapsed
        button_G_bunny_puff.Visibility = Visibility.Collapsed
        button_G_foliage.Visibility = Visibility.Collapsed
        button_G_broken_shell.Visibility = Visibility.Collapsed
        button_G_slurtle_slime.Visibility = Visibility.Collapsed
        button_G_beard_hair.Visibility = Visibility.Collapsed
        button_G_slurper_pelt.Visibility = Visibility.Collapsed
        button_G_thulecite_fragments.Visibility = Visibility.Collapsed
        button_G_down_feather.Visibility = Visibility.Collapsed
        button_G_scales.Visibility = Visibility.Collapsed
        button_G_thick_fur.Visibility = Visibility.Collapsed
        button_G_bamboo_patch.Visibility = Visibility.Collapsed
        button_G_cut_grass_SW.Visibility = Visibility.Collapsed
        button_G_vine.Visibility = Visibility.Collapsed
        button_G_sand.Visibility = Visibility.Collapsed
        button_G_snakeskin.Visibility = Visibility.Collapsed
        button_G_snake_oil.Visibility = Visibility.Collapsed
        button_G_palm_leaf.Visibility = Visibility.Collapsed
        button_G_venom_gland.Visibility = Visibility.Collapsed
        button_G_yellow_mosquito_sack.Visibility = Visibility.Collapsed
        button_G_seashell.Visibility = Visibility.Collapsed
        button_G_doydoy_feather.Visibility = Visibility.Collapsed
        button_G_dubloons.Visibility = Visibility.Collapsed
        button_G_hail.Visibility = Visibility.Collapsed
        button_G_horn.Visibility = Visibility.Collapsed
        button_G_coral.Visibility = Visibility.Collapsed
        button_G_obsidian.Visibility = Visibility.Collapsed
        button_G_cactus_spike.Visibility = Visibility.Collapsed
        button_G_dragoon_heart.Visibility = Visibility.Collapsed
        button_G_turbine_blades.Visibility = Visibility.Collapsed
        button_G_magic_seal.Visibility = Visibility.Collapsed
        button_G_shark_gills.Visibility = Visibility.Collapsed
        button_G_moon_rock.Visibility = Visibility.Collapsed
        button_G_steel_wool.Visibility = Visibility.Collapsed
        button_G_phlegm.Visibility = Visibility.Collapsed
        button_G_fur_tuft.Visibility = Visibility.Collapsed
        REM 装备
        button_G_pickaxe_1.Visibility = Visibility.Collapsed
        button_G_walking_cane.Visibility = Visibility.Collapsed
        button_G_sleek_hat.Visibility = Visibility.Collapsed
        button_G_pretty_parasol.Visibility = Visibility.Collapsed
        button_G_rain_hat.Visibility = Visibility.Collapsed
        button_G_rain_coat.Visibility = Visibility.Collapsed
        button_G_eyebrella.Visibility = Visibility.Collapsed
        button_G_rabbit_earmuffs.Visibility = Visibility.Collapsed
        button_G_beefalo_hat.Visibility = Visibility.Collapsed
        button_G_winter_hat.Visibility = Visibility.Collapsed
        button_G_cat_cap.Visibility = Visibility.Collapsed
        button_G_dapper_vest.Visibility = Visibility.Collapsed
        button_G_breezy_vest.Visibility = Visibility.Collapsed
        button_G_puffy_vest.Visibility = Visibility.Collapsed
        button_G_hibearnation_vest.Visibility = Visibility.Collapsed
        button_G_morning_star.Visibility = Visibility.Collapsed
        button_G_weather_pain.Visibility = Visibility.Collapsed
        button_G_bat_bat.Visibility = Visibility.Collapsed
        button_G_belt_of_hunger.Visibility = Visibility.Collapsed
        button_G_thulecite_club.Visibility = Visibility.Collapsed
        button_G_grass_suit.Visibility = Visibility.Collapsed
        button_G_marble_suit.Visibility = Visibility.Collapsed
        button_G_scalemail.Visibility = Visibility.Collapsed
        button_G_thulecite_crown.Visibility = Visibility.Collapsed
        button_G_thulecite_suit.Visibility = Visibility.Collapsed
        button_G_shelmet.Visibility = Visibility.Collapsed
        button_G_snurtle_shell_armor.Visibility = Visibility.Collapsed
        button_G_tam_o_shanter.Visibility = Visibility.Collapsed
        button_G_spiderhat.Visibility = Visibility.Collapsed
        button_G_slurper.Visibility = Visibility.Collapsed
        button_G_machete.Visibility = Visibility.Collapsed
        button_G_luxury_machete.Visibility = Visibility.Collapsed
        button_G_obsidian_machete.Visibility = Visibility.Collapsed
        button_G_obsidian_axe.Visibility = Visibility.Collapsed
        button_G_rawling.Visibility = Visibility.Collapsed
        button_G_pirate_hat.Visibility = Visibility.Collapsed
        button_G_tropical_parasol.Visibility = Visibility.Collapsed
        button_G_snakeskin_hat.Visibility = Visibility.Collapsed
        button_G_snakeskin_jacket.Visibility = Visibility.Collapsed
        button_G_blubber_suit.Visibility = Visibility.Collapsed
        button_G_dumbrella.Visibility = Visibility.Collapsed
        button_G_windbreaker.Visibility = Visibility.Collapsed
        button_G_boat_cannon.Visibility = Visibility.Collapsed
        button_G_coconade.Visibility = Visibility.Collapsed
        button_G_obsidian_coconade.Visibility = Visibility.Collapsed
        button_G_poison_spear.Visibility = Visibility.Collapsed
        button_G_poison_dart.Visibility = Visibility.Collapsed
        button_G_spear_gun.Visibility = Visibility.Collapsed
        button_G_cutlass_supreme.Visibility = Visibility.Collapsed
        button_G_obsidian_spear.Visibility = Visibility.Collapsed
        button_G_eyeshot.Visibility = Visibility.Collapsed
        button_G_harpoon.Visibility = Visibility.Collapsed
        button_G_peg_leg.Visibility = Visibility.Collapsed
        button_G_trident.Visibility = Visibility.Collapsed
        button_G_seashell_suit.Visibility = Visibility.Collapsed
        button_G_limestone_suit.Visibility = Visibility.Collapsed
        button_G_cactus_armour.Visibility = Visibility.Collapsed
        button_G_horned_helmet.Visibility = Visibility.Collapsed
        button_G_obsidian_armour.Visibility = Visibility.Collapsed
        button_G_portable_crock_pot.Visibility = Visibility.Collapsed
        button_G_saddlehorn.Visibility = Visibility.Collapsed
        button_G_brush.Visibility = Visibility.Collapsed
        button_G_whirly_fan.Visibility = Visibility.Collapsed
        button_G_tail_o_three_cats.Visibility = Visibility.Collapsed
        REM 树苗
        button_G_birchnut.Visibility = Visibility.Collapsed
        button_G_pine_cone.Visibility = Visibility.Collapsed
        button_G_sapling.Visibility = Visibility.Collapsed
        button_G_grass_tuft.Visibility = Visibility.Collapsed
        button_G_berry_bush.Visibility = Visibility.Collapsed
        button_G_berry_bush_2.Visibility = Visibility.Collapsed
        button_G_spiky_bushes.Visibility = Visibility.Collapsed
        button_G_bamboo_root.Visibility = Visibility.Collapsed
        button_G_grass_tuft_SW.Visibility = Visibility.Collapsed
        button_G_coconut.Visibility = Visibility.Collapsed
        button_G_jungle_tree_seed.Visibility = Visibility.Collapsed
        button_G_viney_bush_root.Visibility = Visibility.Collapsed
        button_G_coffee_plant.Visibility = Visibility.Collapsed
        button_G_elephant_cactus_stump.Visibility = Visibility.Collapsed
        button_G_juicy_berry_bush.Visibility = Visibility.Collapsed
        button_G_twiggy_tree_cone.Visibility = Visibility.Collapsed
        REM 生物
        button_G_rabbit.Visibility = Visibility.Collapsed
        button_G_winter_rabbit.Visibility = Visibility.Collapsed
        button_G_beardling.Visibility = Visibility.Collapsed
        button_G_moleworm.Visibility = Visibility.Collapsed
        button_G_bee.Visibility = Visibility.Collapsed
        button_G_killer_bee.Visibility = Visibility.Collapsed
        button_G_butterfly.Visibility = Visibility.Collapsed
        button_G_mosquito.Visibility = Visibility.Collapsed
        button_G_redbird.Visibility = Visibility.Collapsed
        button_G_snowbird.Visibility = Visibility.Collapsed
        button_G_crow.Visibility = Visibility.Collapsed
        button_G_fireflies.Visibility = Visibility.Collapsed
        button_G_crabbit.Visibility = Visibility.Collapsed
        button_G_beardling_sw.Visibility = Visibility.Collapsed
        button_G_dead_dogfish.Visibility = Visibility.Collapsed
        button_G_dead_swordfish.Visibility = Visibility.Collapsed
        button_G_dead_wobster.Visibility = Visibility.Collapsed
        button_G_bioluminescence.Visibility = Visibility.Collapsed
        button_G_jellyfish.Visibility = Visibility.Collapsed
        button_G_dead_jellyfish.Visibility = Visibility.Collapsed
        button_G_butterfly_sw.Visibility = Visibility.Collapsed
        button_G_mosquito_sw.Visibility = Visibility.Collapsed
        button_G_parrot.Visibility = Visibility.Collapsed
        button_G_parrot_pirate.Visibility = Visibility.Collapsed
        button_G_toucan.Visibility = Visibility.Collapsed
        button_G_seagull.Visibility = Visibility.Collapsed
        button_G_blue_spore.Visibility = Visibility.Collapsed
        button_G_green_spore.Visibility = Visibility.Collapsed
        button_G_red_spore.Visibility = Visibility.Collapsed
        REM 玩具
        button_G_air_unfreshener.Visibility = Visibility.Collapsed
        button_G_back_scratcher.Visibility = Visibility.Collapsed
        button_G_ball_and_cup.Visibility = Visibility.Collapsed
        button_G_beaten_beater.Visibility = Visibility.Collapsed
        button_G_bent_spork.Visibility = Visibility.Collapsed
        button_G_black_bishop.Visibility = Visibility.Collapsed
        button_G_dessicated_tentacle.Visibility = Visibility.Collapsed
        button_G_fake_kazoo.Visibility = Visibility.Collapsed
        button_G_frayed_yarn.Visibility = Visibility.Collapsed
        button_G_frazzled_wires.Visibility = Visibility.Collapsed
        button_G_gnome_1.Visibility = Visibility.Collapsed
        button_G_gnome_2.Visibility = Visibility.Collapsed
        button_G_gords_knot.Visibility = Visibility.Collapsed
        button_G_hardened_rubber_bung.Visibility = Visibility.Collapsed
        button_G_leaky_teacup.Visibility = Visibility.Collapsed
        button_G_lucky_cat_jar.Visibility = Visibility.Collapsed
        button_G_lying_robot.Visibility = Visibility.Collapsed
        button_G_melty_marbles.Visibility = Visibility.Collapsed
        button_G_mismatched_buttons.Visibility = Visibility.Collapsed
        button_G_potato_cup.Visibility = Visibility.Collapsed
        button_G_second_hand_dentures.Visibility = Visibility.Collapsed
        button_G_shoe_horn.Visibility = Visibility.Collapsed
        button_G_tiny_rocketship.Visibility = Visibility.Collapsed
        button_G_toy_trojan_horse.Visibility = Visibility.Collapsed
        button_G_unbalanced_top.Visibility = Visibility.Collapsed
        button_G_white_bishop.Visibility = Visibility.Collapsed
        button_G_wire_hanger.Visibility = Visibility.Collapsed
        button_G_ancient_vase.Visibility = Visibility.Collapsed
        button_G_brain_cloud_pill.Visibility = Visibility.Collapsed
        button_G_broken_AAC_device.Visibility = Visibility.Collapsed
        button_G_license_plate.Visibility = Visibility.Collapsed
        button_G_old_boot.Visibility = Visibility.Collapsed
        button_G_one_true_earring.Visibility = Visibility.Collapsed
        button_G_orange_soda.Visibility = Visibility.Collapsed
        button_G_sea_worther.Visibility = Visibility.Collapsed
        button_G_sextant.Visibility = Visibility.Collapsed
        button_G_soaked_candle.Visibility = Visibility.Collapsed
        button_G_toy_boat.Visibility = Visibility.Collapsed
        button_G_ukulele.Visibility = Visibility.Collapsed
        button_G_voodoo_doll.Visibility = Visibility.Collapsed
        button_G_wine_bottle_candle.Visibility = Visibility.Collapsed
        REM 草皮
        button_G_checkered_flooring.Visibility = Visibility.Collapsed
        button_G_carpeted_flooring.Visibility = Visibility.Collapsed
        button_G_deciduous_turf.Visibility = Visibility.Collapsed
        button_G_forest_turf.Visibility = Visibility.Collapsed
        button_G_grass_turf.Visibility = Visibility.Collapsed
        button_G_marsh_turf.Visibility = Visibility.Collapsed
        button_G_meadow_turf.Visibility = Visibility.Collapsed
        button_G_rocky_turf.Visibility = Visibility.Collapsed
        button_G_sandy_turf.Visibility = Visibility.Collapsed
        button_G_savanna_turf.Visibility = Visibility.Collapsed
        button_G_cave_rock_turf.Visibility = Visibility.Collapsed
        button_G_fungal_turf_blue.Visibility = Visibility.Collapsed
        button_G_fungal_turf_green.Visibility = Visibility.Collapsed
        button_G_fungal_turf_red.Visibility = Visibility.Collapsed
        button_G_guano_turf.Visibility = Visibility.Collapsed
        button_G_mud_turf.Visibility = Visibility.Collapsed
        button_G_slimey_turf.Visibility = Visibility.Collapsed
        button_G_snakeskin_rug.Visibility = Visibility.Collapsed
        button_G_jungle_turf.Visibility = Visibility.Collapsed
        button_G_magma_turf.Visibility = Visibility.Collapsed
        button_G_tidal_marsh_turf.Visibility = Visibility.Collapsed
        button_G_ashy_turf.Visibility = Visibility.Collapsed
        button_G_volcano_turf.Visibility = Visibility.Collapsed
        button_G_beach_turf.Visibility = Visibility.Collapsed
        button_G_scaled_flooring.Visibility = Visibility.Collapsed
        REM 宠物
        button_G_eye_bone.Visibility = Visibility.Collapsed
        button_G_fishbone.Visibility = Visibility.Collapsed
        button_G_lavae_egg.Visibility = Visibility.Collapsed
        button_G_lavae_tooth.Visibility = Visibility.Collapsed
        button_G_star_sky.Visibility = Visibility.Collapsed
        REM 解锁
        button_G_webbers_skull.Visibility = Visibility.Collapsed
        button_G_iron_key.Visibility = Visibility.Collapsed
        button_G_golden_key.Visibility = Visibility.Collapsed
        button_G_bone_key.Visibility = Visibility.Collapsed
        button_G_tarnished_crown.Visibility = Visibility.Collapsed
        button_G_grassy_thing.Visibility = Visibility.Collapsed
        button_G_ring_thing_sw.Visibility = Visibility.Collapsed
        button_G_screw_thing.Visibility = Visibility.Collapsed
        button_G_wooden_potato_thing.Visibility = Visibility.Collapsed
        REM 零件
        button_G_box_thing.Visibility = Visibility.Collapsed
        button_G_crank_thing.Visibility = Visibility.Collapsed
        button_G_metal_potato_thing.Visibility = Visibility.Collapsed
        button_G_ring_thing.Visibility = Visibility.Collapsed
        REM 其他
        button_G_ballphin_free_tuna.Visibility = Visibility.Collapsed
        button_G_message_in_a_bottle.Visibility = Visibility.Collapsed
    End Sub

    Private Sub G_DLC_ROG_SHOW()
        REM 材料
        button_G_marble.Visibility = Visibility.Visible
        button_G_beefalo_horn.Visibility = Visibility.Visible
        button_G_guano.Visibility = Visibility.Visible
        button_G_glommers_flower.Visibility = Visibility.Visible
        button_G_mosquito_sack.Visibility = Visibility.Visible
        button_G_volt_goat_horn.Visibility = Visibility.Visible
        button_G_walrus_tusk.Visibility = Visibility.Visible
        button_G_light_bulb.Visibility = Visibility.Visible
        button_G_bunny_puff.Visibility = Visibility.Visible
        button_G_foliage.Visibility = Visibility.Visible
        button_G_broken_shell.Visibility = Visibility.Visible
        button_G_slurtle_slime.Visibility = Visibility.Visible
        button_G_beard_hair.Visibility = Visibility.Visible
        button_G_slurper_pelt.Visibility = Visibility.Visible
        button_G_thulecite_fragments.Visibility = Visibility.Visible
        button_G_down_feather.Visibility = Visibility.Visible
        button_G_scales.Visibility = Visibility.Visible
        button_G_thick_fur.Visibility = Visibility.Visible
        REM 装备
        button_G_pickaxe_1.Visibility = Visibility.Visible
        button_G_walking_cane.Visibility = Visibility.Visible
        button_G_pretty_parasol.Visibility = Visibility.Visible
        button_G_rain_hat.Visibility = Visibility.Visible
        button_G_rain_coat.Visibility = Visibility.Visible
        button_G_eyebrella.Visibility = Visibility.Visible
        button_G_rabbit_earmuffs.Visibility = Visibility.Visible
        button_G_beefalo_hat.Visibility = Visibility.Visible
        button_G_winter_hat.Visibility = Visibility.Visible
        button_G_cat_cap.Visibility = Visibility.Visible
        button_G_dapper_vest.Visibility = Visibility.Visible
        button_G_breezy_vest.Visibility = Visibility.Visible
        button_G_puffy_vest.Visibility = Visibility.Visible
        button_G_hibearnation_vest.Visibility = Visibility.Visible
        button_G_morning_star.Visibility = Visibility.Visible
        button_G_weather_pain.Visibility = Visibility.Visible
        button_G_bat_bat.Visibility = Visibility.Visible
        button_G_belt_of_hunger.Visibility = Visibility.Visible
        button_G_thulecite_club.Visibility = Visibility.Visible
        button_G_grass_suit.Visibility = Visibility.Visible
        button_G_marble_suit.Visibility = Visibility.Visible
        button_G_scalemail.Visibility = Visibility.Visible
        button_G_thulecite_crown.Visibility = Visibility.Visible
        button_G_thulecite_suit.Visibility = Visibility.Visible
        button_G_shelmet.Visibility = Visibility.Visible
        button_G_snurtle_shell_armor.Visibility = Visibility.Visible
        button_G_tam_o_shanter.Visibility = Visibility.Visible
        button_G_spiderhat.Visibility = Visibility.Visible
        button_G_slurper.Visibility = Visibility.Visible
        REM 树苗
        button_G_birchnut.Visibility = Visibility.Visible
        button_G_pine_cone.Visibility = Visibility.Visible
        button_G_sapling.Visibility = Visibility.Visible
        button_G_grass_tuft.Visibility = Visibility.Visible
        button_G_berry_bush.Visibility = Visibility.Visible
        button_G_berry_bush_2.Visibility = Visibility.Visible
        button_G_spiky_bushes.Visibility = Visibility.Visible
        REM 生物
        button_G_rabbit.Visibility = Visibility.Visible
        button_G_winter_rabbit.Visibility = Visibility.Visible
        button_G_beardling.Visibility = Visibility.Visible
        button_G_moleworm.Visibility = Visibility.Visible
        button_G_bee.Visibility = Visibility.Visible
        button_G_killer_bee.Visibility = Visibility.Visible
        button_G_butterfly.Visibility = Visibility.Visible
        button_G_mosquito.Visibility = Visibility.Visible
        button_G_redbird.Visibility = Visibility.Visible
        button_G_snowbird.Visibility = Visibility.Visible
        button_G_crow.Visibility = Visibility.Visible
        button_G_fireflies.Visibility = Visibility.Visible
        REM 玩具
        button_G_ball_and_cup.Visibility = Visibility.Visible
        button_G_dessicated_tentacle.Visibility = Visibility.Visible
        button_G_fake_kazoo.Visibility = Visibility.Visible
        button_G_frazzled_wires.Visibility = Visibility.Visible
        button_G_gnome_1.Visibility = Visibility.Visible
        button_G_gords_knot.Visibility = Visibility.Visible
        button_G_hardened_rubber_bung.Visibility = Visibility.Visible
        button_G_lying_robot.Visibility = Visibility.Visible
        button_G_melty_marbles.Visibility = Visibility.Visible
        button_G_mismatched_buttons.Visibility = Visibility.Visible
        button_G_second_hand_dentures.Visibility = Visibility.Visible
        button_G_tiny_rocketship.Visibility = Visibility.Visible
        REM 草皮
        button_G_checkered_flooring.Visibility = Visibility.Visible
        button_G_carpeted_flooring.Visibility = Visibility.Visible
        button_G_deciduous_turf.Visibility = Visibility.Visible
        button_G_forest_turf.Visibility = Visibility.Visible
        button_G_grass_turf.Visibility = Visibility.Visible
        button_G_marsh_turf.Visibility = Visibility.Visible
        button_G_meadow_turf.Visibility = Visibility.Visible
        button_G_rocky_turf.Visibility = Visibility.Visible
        button_G_sandy_turf.Visibility = Visibility.Visible
        button_G_savanna_turf.Visibility = Visibility.Visible
        button_G_cave_rock_turf.Visibility = Visibility.Visible
        button_G_fungal_turf_blue.Visibility = Visibility.Visible
        button_G_fungal_turf_green.Visibility = Visibility.Visible
        button_G_fungal_turf_red.Visibility = Visibility.Visible
        button_G_guano_turf.Visibility = Visibility.Visible
        button_G_mud_turf.Visibility = Visibility.Visible
        button_G_slimey_turf.Visibility = Visibility.Visible
        REM 宠物
        button_G_eye_bone.Visibility = Visibility.Visible
        REM 解锁
        button_G_webbers_skull.Visibility = Visibility.Visible
        REM 零件
        button_G_box_thing.Visibility = Visibility.Visible
        button_G_crank_thing.Visibility = Visibility.Visible
        button_G_metal_potato_thing.Visibility = Visibility.Visible
        button_G_ring_thing.Visibility = Visibility.Visible
        REM 其他

    End Sub

    Private Sub G_DLC_SW_SHOW()
        REM 材料
        button_G_bamboo_patch.Visibility = Visibility.Visible
        button_G_cut_grass_SW.Visibility = Visibility.Visible
        button_G_vine.Visibility = Visibility.Visible
        button_G_sand.Visibility = Visibility.Visible
        button_G_snakeskin.Visibility = Visibility.Visible
        button_G_snake_oil.Visibility = Visibility.Visible
        button_G_palm_leaf.Visibility = Visibility.Visible
        button_G_venom_gland.Visibility = Visibility.Visible
        button_G_yellow_mosquito_sack.Visibility = Visibility.Visible
        button_G_seashell.Visibility = Visibility.Visible
        button_G_doydoy_feather.Visibility = Visibility.Visible
        button_G_dubloons.Visibility = Visibility.Visible
        button_G_hail.Visibility = Visibility.Visible
        button_G_horn.Visibility = Visibility.Visible
        button_G_coral.Visibility = Visibility.Visible
        button_G_obsidian.Visibility = Visibility.Visible
        button_G_cactus_spike.Visibility = Visibility.Visible
        button_G_dragoon_heart.Visibility = Visibility.Visible
        button_G_turbine_blades.Visibility = Visibility.Visible
        button_G_magic_seal.Visibility = Visibility.Visible
        button_G_shark_gills.Visibility = Visibility.Visible
        REM 装备
        button_G_machete.Visibility = Visibility.Visible
        button_G_luxury_machete.Visibility = Visibility.Visible
        button_G_obsidian_machete.Visibility = Visibility.Visible
        button_G_obsidian_axe.Visibility = Visibility.Visible
        button_G_sleek_hat.Visibility = Visibility.Visible
        button_G_rawling.Visibility = Visibility.Visible
        button_G_pirate_hat.Visibility = Visibility.Visible
        button_G_tropical_parasol.Visibility = Visibility.Visible
        button_G_snakeskin_hat.Visibility = Visibility.Visible
        button_G_snakeskin_jacket.Visibility = Visibility.Visible
        button_G_blubber_suit.Visibility = Visibility.Visible
        button_G_dumbrella.Visibility = Visibility.Visible
        button_G_windbreaker.Visibility = Visibility.Visible
        button_G_boat_cannon.Visibility = Visibility.Visible
        button_G_coconade.Visibility = Visibility.Visible
        button_G_obsidian_coconade.Visibility = Visibility.Visible
        button_G_poison_spear.Visibility = Visibility.Visible
        button_G_poison_dart.Visibility = Visibility.Visible
        button_G_spear_gun.Visibility = Visibility.Visible
        button_G_cutlass_supreme.Visibility = Visibility.Visible
        button_G_obsidian_spear.Visibility = Visibility.Visible
        button_G_eyeshot.Visibility = Visibility.Visible
        button_G_harpoon.Visibility = Visibility.Visible
        button_G_peg_leg.Visibility = Visibility.Visible
        button_G_trident.Visibility = Visibility.Visible
        button_G_seashell_suit.Visibility = Visibility.Visible
        button_G_limestone_suit.Visibility = Visibility.Visible
        button_G_cactus_armour.Visibility = Visibility.Visible
        button_G_horned_helmet.Visibility = Visibility.Visible
        button_G_obsidian_armour.Visibility = Visibility.Visible
        button_G_portable_crock_pot.Visibility = Visibility.Visible
        REM 树苗
        button_G_bamboo_root.Visibility = Visibility.Visible
        button_G_grass_tuft_SW.Visibility = Visibility.Visible
        button_G_coconut.Visibility = Visibility.Visible
        button_G_jungle_tree_seed.Visibility = Visibility.Visible
        button_G_viney_bush_root.Visibility = Visibility.Visible
        button_G_coffee_plant.Visibility = Visibility.Visible
        button_G_elephant_cactus_stump.Visibility = Visibility.Visible
        REM 生物
        button_G_crabbit.Visibility = Visibility.Visible
        button_G_beardling_sw.Visibility = Visibility.Visible
        button_G_dead_dogfish.Visibility = Visibility.Visible
        button_G_dead_swordfish.Visibility = Visibility.Visible
        button_G_dead_wobster.Visibility = Visibility.Visible
        button_G_bioluminescence.Visibility = Visibility.Visible
        button_G_jellyfish.Visibility = Visibility.Visible
        button_G_dead_jellyfish.Visibility = Visibility.Visible
        button_G_butterfly_sw.Visibility = Visibility.Visible
        button_G_mosquito_sw.Visibility = Visibility.Visible
        button_G_parrot.Visibility = Visibility.Visible
        button_G_parrot_pirate.Visibility = Visibility.Visible
        button_G_toucan.Visibility = Visibility.Visible
        button_G_seagull.Visibility = Visibility.Visible
        REM 玩具
        button_G_ancient_vase.Visibility = Visibility.Visible
        button_G_brain_cloud_pill.Visibility = Visibility.Visible
        button_G_broken_AAC_device.Visibility = Visibility.Visible
        button_G_license_plate.Visibility = Visibility.Visible
        button_G_old_boot.Visibility = Visibility.Visible
        button_G_one_true_earring.Visibility = Visibility.Visible
        button_G_orange_soda.Visibility = Visibility.Visible
        button_G_sea_worther.Visibility = Visibility.Visible
        button_G_sextant.Visibility = Visibility.Visible
        button_G_soaked_candle.Visibility = Visibility.Visible
        button_G_toy_boat.Visibility = Visibility.Visible
        button_G_ukulele.Visibility = Visibility.Visible
        button_G_voodoo_doll.Visibility = Visibility.Visible
        button_G_wine_bottle_candle.Visibility = Visibility.Visible
        REM 草皮
        button_G_snakeskin_rug.Visibility = Visibility.Visible
        button_G_jungle_turf.Visibility = Visibility.Visible
        button_G_magma_turf.Visibility = Visibility.Visible
        button_G_tidal_marsh_turf.Visibility = Visibility.Visible
        button_G_ashy_turf.Visibility = Visibility.Visible
        button_G_volcano_turf.Visibility = Visibility.Visible
        button_G_beach_turf.Visibility = Visibility.Visible
        REM 宠物
        button_G_fishbone.Visibility = Visibility.Visible
        REM 解锁
        button_G_iron_key.Visibility = Visibility.Visible
        button_G_golden_key.Visibility = Visibility.Visible
        button_G_bone_key.Visibility = Visibility.Visible
        button_G_tarnished_crown.Visibility = Visibility.Visible
        REM 零件
        button_G_grassy_thing.Visibility = Visibility.Visible
        button_G_ring_thing_sw.Visibility = Visibility.Visible
        button_G_screw_thing.Visibility = Visibility.Visible
        button_G_wooden_potato_thing.Visibility = Visibility.Visible
        REM 其他
        button_G_ballphin_free_tuna.Visibility = Visibility.Visible
        button_G_message_in_a_bottle.Visibility = Visibility.Visible
    End Sub

    Private Sub G_DLC_DST_SHOW()
        REM 材料
        button_G_marble.Visibility = Visibility.Visible
        button_G_moon_rock.Visibility = Visibility.Visible
        button_G_beefalo_horn.Visibility = Visibility.Visible
        button_G_guano.Visibility = Visibility.Visible
        button_G_glommers_flower.Visibility = Visibility.Visible
        button_G_mosquito_sack.Visibility = Visibility.Visible
        button_G_volt_goat_horn.Visibility = Visibility.Visible
        button_G_walrus_tusk.Visibility = Visibility.Visible
        button_G_steel_wool.Visibility = Visibility.Visible
        button_G_phlegm.Visibility = Visibility.Visible
        button_G_light_bulb.Visibility = Visibility.Visible
        button_G_bunny_puff.Visibility = Visibility.Visible
        button_G_foliage.Visibility = Visibility.Visible
        button_G_broken_shell.Visibility = Visibility.Visible
        button_G_slurtle_slime.Visibility = Visibility.Visible
        button_G_beard_hair.Visibility = Visibility.Visible
        button_G_slurper_pelt.Visibility = Visibility.Visible
        button_G_thulecite_fragments.Visibility = Visibility.Visible
        button_G_down_feather.Visibility = Visibility.Visible
        button_G_scales.Visibility = Visibility.Visible
        button_G_fur_tuft.Visibility = Visibility.Visible
        button_G_thick_fur.Visibility = Visibility.Visible
        REM 装备
        button_G_saddlehorn.Visibility = Visibility.Visible
        button_G_brush.Visibility = Visibility.Visible
        button_G_pickaxe_1.Visibility = Visibility.Visible
        button_G_walking_cane.Visibility = Visibility.Visible
        button_G_pretty_parasol.Visibility = Visibility.Visible
        button_G_rain_hat.Visibility = Visibility.Visible
        button_G_rain_coat.Visibility = Visibility.Visible
        button_G_eyebrella.Visibility = Visibility.Visible
        button_G_whirly_fan.Visibility = Visibility.Visible
        button_G_rabbit_earmuffs.Visibility = Visibility.Visible
        button_G_beefalo_hat.Visibility = Visibility.Visible
        button_G_winter_hat.Visibility = Visibility.Visible
        button_G_cat_cap.Visibility = Visibility.Visible
        button_G_dapper_vest.Visibility = Visibility.Visible
        button_G_breezy_vest.Visibility = Visibility.Visible
        button_G_puffy_vest.Visibility = Visibility.Visible
        button_G_hibearnation_vest.Visibility = Visibility.Visible
        button_G_morning_star.Visibility = Visibility.Visible
        button_G_tail_o_three_cats.Visibility = Visibility.Visible
        button_G_weather_pain.Visibility = Visibility.Visible
        button_G_bat_bat.Visibility = Visibility.Visible
        button_G_belt_of_hunger.Visibility = Visibility.Visible
        button_G_thulecite_club.Visibility = Visibility.Visible
        button_G_grass_suit.Visibility = Visibility.Visible
        button_G_marble_suit.Visibility = Visibility.Visible
        button_G_scalemail.Visibility = Visibility.Visible
        button_G_thulecite_crown.Visibility = Visibility.Visible
        button_G_thulecite_suit.Visibility = Visibility.Visible
        button_G_shelmet.Visibility = Visibility.Visible
        button_G_snurtle_shell_armor.Visibility = Visibility.Visible
        button_G_tam_o_shanter.Visibility = Visibility.Visible
        button_G_spiderhat.Visibility = Visibility.Visible
        button_G_slurper.Visibility = Visibility.Visible
        REM 树苗
        button_G_birchnut.Visibility = Visibility.Visible
        button_G_pine_cone.Visibility = Visibility.Visible
        button_G_sapling.Visibility = Visibility.Visible
        button_G_grass_tuft.Visibility = Visibility.Visible
        button_G_berry_bush.Visibility = Visibility.Visible
        button_G_berry_bush_2.Visibility = Visibility.Visible
        button_G_spiky_bushes.Visibility = Visibility.Visible
        button_G_juicy_berry_bush.Visibility = Visibility.Visible
        button_G_twiggy_tree_cone.Visibility = Visibility.Visible
        REM 生物
        button_G_rabbit.Visibility = Visibility.Visible
        button_G_winter_rabbit.Visibility = Visibility.Visible
        button_G_beardling.Visibility = Visibility.Visible
        button_G_moleworm.Visibility = Visibility.Visible
        button_G_bee.Visibility = Visibility.Visible
        button_G_killer_bee.Visibility = Visibility.Visible
        button_G_butterfly.Visibility = Visibility.Visible
        button_G_mosquito.Visibility = Visibility.Visible
        button_G_redbird.Visibility = Visibility.Visible
        button_G_snowbird.Visibility = Visibility.Visible
        button_G_crow.Visibility = Visibility.Visible
        button_G_fireflies.Visibility = Visibility.Visible
        button_G_blue_spore.Visibility = Visibility.Visible
        button_G_green_spore.Visibility = Visibility.Visible
        button_G_red_spore.Visibility = Visibility.Visible
        REM 玩具
        button_G_air_unfreshener.Visibility = Visibility.Visible
        button_G_back_scratcher.Visibility = Visibility.Visible
        button_G_ball_and_cup.Visibility = Visibility.Visible
        button_G_beaten_beater.Visibility = Visibility.Visible
        button_G_bent_spork.Visibility = Visibility.Visible
        button_G_black_bishop.Visibility = Visibility.Visible
        button_G_dessicated_tentacle.Visibility = Visibility.Visible
        button_G_fake_kazoo.Visibility = Visibility.Visible
        button_G_frayed_yarn.Visibility = Visibility.Visible
        button_G_frazzled_wires.Visibility = Visibility.Visible
        button_G_gnome_1.Visibility = Visibility.Visible
        button_G_gnome_2.Visibility = Visibility.Visible
        button_G_gords_knot.Visibility = Visibility.Visible
        button_G_hardened_rubber_bung.Visibility = Visibility.Visible
        button_G_leaky_teacup.Visibility = Visibility.Visible
        button_G_lucky_cat_jar.Visibility = Visibility.Visible
        button_G_lying_robot.Visibility = Visibility.Visible
        button_G_melty_marbles.Visibility = Visibility.Visible
        button_G_mismatched_buttons.Visibility = Visibility.Visible
        button_G_potato_cup.Visibility = Visibility.Visible
        button_G_second_hand_dentures.Visibility = Visibility.Visible
        button_G_shoe_horn.Visibility = Visibility.Visible
        button_G_tiny_rocketship.Visibility = Visibility.Visible
        button_G_toy_trojan_horse.Visibility = Visibility.Visible
        button_G_unbalanced_top.Visibility = Visibility.Visible
        button_G_white_bishop.Visibility = Visibility.Visible
        button_G_wire_hanger.Visibility = Visibility.Visible
        REM 草皮
        button_G_checkered_flooring.Visibility = Visibility.Visible
        button_G_carpeted_flooring.Visibility = Visibility.Visible
        button_G_scaled_flooring.Visibility = Visibility.Visible
        button_G_deciduous_turf.Visibility = Visibility.Visible
        button_G_forest_turf.Visibility = Visibility.Visible
        button_G_grass_turf.Visibility = Visibility.Visible
        button_G_marsh_turf.Visibility = Visibility.Visible
        button_G_meadow_turf.Visibility = Visibility.Visible
        button_G_rocky_turf.Visibility = Visibility.Visible
        button_G_sandy_turf.Visibility = Visibility.Visible
        button_G_savanna_turf.Visibility = Visibility.Visible
        button_G_cave_rock_turf.Visibility = Visibility.Visible
        button_G_fungal_turf_blue.Visibility = Visibility.Visible
        button_G_fungal_turf_green.Visibility = Visibility.Visible
        button_G_fungal_turf_red.Visibility = Visibility.Visible
        button_G_guano_turf.Visibility = Visibility.Visible
        button_G_mud_turf.Visibility = Visibility.Visible
        REM 宠
        button_G_eye_bone.Visibility = Visibility.Visible
        button_G_lavae_egg.Visibility = Visibility.Visible
        button_G_lavae_tooth.Visibility = Visibility.Visible
        button_G_star_sky.Visibility = Visibility.Visible
        REM 解锁

        REM 零件

        REM 其他
    End Sub

    REM 物品DLC检测
    Private Sub G_DLC_Check()

        Dim G_ROG_SW_DST As SByte
        Dim G_ROG__ As SByte
        Dim G_SW__ As SByte
        Dim G_DST__ As SByte
        If checkBox_G_DLC_ROG.IsChecked = True Then
            G_ROG__ = 1
        Else
            G_ROG__ = 0
        End If
        If checkBox_G_DLC_SW.IsChecked = True Then
            G_SW__ = 2
        Else
            G_SW__ = 0
        End If
        If checkBox_G_DLC_DST.IsChecked = True Then
            G_DST__ = 4
        Else
            G_DST__ = 0
        End If
        G_ROG_SW_DST = G_ROG__ + G_SW__ + G_DST__
        If G_ROG_SW_DST = 0 Then
            MsgBox("至少选择一项！")
            checkBox_G_DLC_ROG.IsChecked = True
            G_DLC_Check()
        Else
            G_DLC_Check_initialization()
            Select Case G_ROG_SW_DST
                Case 1
                    G_DLC_ROG_SHOW()
                    WrapPanel_G_material.Height = 410
                    WrapPanel_G_equipment.Height = 570
                    WrapPanel_G_sapling.Height = 90
                    WrapPanel_G_animal.Height = 170
                    WrapPanel_G_toys.Height = 170
                    WrapPanel_G_turf.Height = 170
                    TextBlock_G_unlock.Visibility = Visibility.Visible
                    WrapPanel_G_unlock.Visibility = Visibility.Visible
                    TextBlock_G_component.Visibility = Visibility.Visible
                    WrapPanel_G_component.Visibility = Visibility.Visible
                    WrapPanel_Goods.Height = 3270 - 11 * 80
                    Reg_Write("Goods", 1)
                Case 2
                    G_DLC_SW_SHOW()
                    WrapPanel_G_material.Height = 490
                    WrapPanel_G_equipment.Height = 570
                    WrapPanel_G_sapling.Height = 90
                    WrapPanel_G_animal.Height = 170
                    WrapPanel_G_toys.Height = 170
                    WrapPanel_G_turf.Height = 90
                    TextBlock_G_unlock.Visibility = Visibility.Visible
                    WrapPanel_G_unlock.Visibility = Visibility.Visible
                    TextBlock_G_component.Visibility = Visibility.Visible
                    WrapPanel_G_component.Visibility = Visibility.Visible
                    WrapPanel_Goods.Height = 3270 - 11 * 80
                    Reg_Write("Goods", 2)
                Case 3
                    G_DLC_ROG_SHOW()
                    G_DLC_SW_SHOW()
                    WrapPanel_G_material.Height = 570
                    WrapPanel_G_equipment.Height = 730
                    WrapPanel_G_sapling.Height = 170
                    WrapPanel_G_animal.Height = 250
                    WrapPanel_G_toys.Height = 250
                    WrapPanel_G_turf.Height = 250
                    TextBlock_G_unlock.Visibility = Visibility.Visible
                    WrapPanel_G_unlock.Visibility = Visibility.Visible
                    TextBlock_G_component.Visibility = Visibility.Visible
                    WrapPanel_G_component.Visibility = Visibility.Visible
                    WrapPanel_Goods.Height = 3270 - 3 * 80
                    Reg_Write("Goods", 3)
                Case 4
                    G_DLC_DST_SHOW()
                    WrapPanel_G_material.Height = 490
                    WrapPanel_G_equipment.Height = 570
                    WrapPanel_G_sapling.Height = 90
                    WrapPanel_G_animal.Height = 170
                    WrapPanel_G_toys.Height = 250
                    WrapPanel_G_turf.Height = 170
                    TextBlock_G_unlock.Visibility = Visibility.Collapsed
                    WrapPanel_G_unlock.Visibility = Visibility.Collapsed
                    TextBlock_G_component.Visibility = Visibility.Collapsed
                    WrapPanel_G_component.Visibility = Visibility.Collapsed
                    WrapPanel_Goods.Height = 3270 - 11 * 80 - 35.4 * 2
                    Reg_Write("Goods", 4)
                Case 5
                    G_DLC_ROG_SHOW()
                    G_DLC_DST_SHOW()
                    WrapPanel_G_material.Height = 490
                    WrapPanel_G_equipment.Height = 570
                    WrapPanel_G_sapling.Height = 90
                    WrapPanel_G_animal.Height = 170
                    WrapPanel_G_toys.Height = 250
                    WrapPanel_G_turf.Height = 170
                    TextBlock_G_unlock.Visibility = Visibility.Visible
                    WrapPanel_G_unlock.Visibility = Visibility.Visible
                    TextBlock_G_component.Visibility = Visibility.Visible
                    WrapPanel_G_component.Visibility = Visibility.Visible
                    WrapPanel_Goods.Height = 3270 - 9 * 80
                    Reg_Write("Goods", 5)
                Case 6
                    G_DLC_SW_SHOW()
                    G_DLC_DST_SHOW()
                    WrapPanel_G_material.Height = 650
                    WrapPanel_G_equipment.Height = 810
                    WrapPanel_G_sapling.Height = 170
                    WrapPanel_G_animal.Height = 250
                    WrapPanel_G_toys.Height = 330
                    WrapPanel_G_turf.Height = 250
                    TextBlock_G_unlock.Visibility = Visibility.Visible
                    WrapPanel_G_unlock.Visibility = Visibility.Visible
                    TextBlock_G_component.Visibility = Visibility.Visible
                    WrapPanel_G_component.Visibility = Visibility.Visible
                    WrapPanel_Goods.Height = 3270
                    Reg_Write("Goods", 6)
                Case 7
                    G_DLC_ROG_SHOW()
                    G_DLC_SW_SHOW()
                    G_DLC_DST_SHOW()
                    WrapPanel_G_material.Height = 650
                    WrapPanel_G_equipment.Height = 810
                    WrapPanel_G_sapling.Height = 170
                    WrapPanel_G_animal.Height = 250
                    WrapPanel_G_toys.Height = 330
                    WrapPanel_G_turf.Height = 250
                    TextBlock_G_unlock.Visibility = Visibility.Visible
                    WrapPanel_G_unlock.Visibility = Visibility.Visible
                    TextBlock_G_component.Visibility = Visibility.Visible
                    WrapPanel_G_component.Visibility = Visibility.Visible
                    WrapPanel_Goods.Height = 3270
                    Reg_Write("Goods", 7)
            End Select
        End If
    End Sub

    Private Sub checkBox_G_DLC_ROG_click(sender As Object, e As RoutedEventArgs) Handles checkBox_G_DLC_ROG.Click
        G_DLC_Check()
    End Sub

    Private Sub GL_button_G_DLC_ROG_click(sender As Object, e As RoutedEventArgs) Handles GL_button_G_DLC_ROG.Click
        If checkBox_G_DLC_ROG.IsChecked = True Then
            checkBox_G_DLC_ROG.IsChecked = False
        Else
            checkBox_G_DLC_ROG.IsChecked = True
        End If
        checkBox_G_DLC_ROG_click(Nothing, Nothing)
    End Sub

    Private Sub checkBox_G_DLC_SW_click(sender As Object, e As RoutedEventArgs) Handles checkBox_G_DLC_SW.Click
        G_DLC_Check()
    End Sub

    Private Sub GL_button_G_DLC_SW_click(sender As Object, e As RoutedEventArgs) Handles GL_button_G_DLC_SW.Click
        If checkBox_G_DLC_SW.IsChecked = True Then
            checkBox_G_DLC_SW.IsChecked = False
        Else
            checkBox_G_DLC_SW.IsChecked = True
        End If
        checkBox_G_DLC_SW_click(Nothing, Nothing)
    End Sub

    Private Sub checkBox_G_DLC_DST_click(sender As Object, e As RoutedEventArgs) Handles checkBox_G_DLC_DST.Click
        G_DLC_Check()
    End Sub

    Private Sub GL_button_G_DLC_DST_click(sender As Object, e As RoutedEventArgs) Handles GL_button_G_DLC_DST.Click
        If checkBox_G_DLC_DST.IsChecked = True Then
            checkBox_G_DLC_DST.IsChecked = False
        Else
            checkBox_G_DLC_DST.IsChecked = True
        End If
        checkBox_G_DLC_DST_click(Nothing, Nothing)
    End Sub
#End Region

#Region "设置"
    Private Sub Se_button_CreateShortCut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Se_button_CreateShortCut.Click
        ' 使用COM导入库
        Dim wsh As New IWshShell_Class
        Dim desk As String = wsh.SpecialFolders.Item("Desktop") '从SHELL枚举中获得桌面路径
        Dim lnk As IWshShortcut = wsh.CreateShortcut(desk & "\饥荒百科全书.lnk") '在桌面上创建说明文件的路径，注意扩展名为 .lnk

        With lnk
            '.Arguments = "/?" '传递参数
            .Description = "饥荒百科全书"
            '.IconLocation = Application.StartupPath & "\Mac.ico" '快捷方式的图标，空表示使用默认文件图标，可使用ico或exe、dll shell.dll,23
            .TargetPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase & Process.GetCurrentProcess.ProcessName & ".exe" '目标文件路径
            .WindowStyle = 1 '打开窗体的风格
            .WorkingDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase '工作路径

            .Save() '保存快捷方式
        End With

        MsgBox("已创建桌面快捷方式!", MsgBoxStyle.Information)
    End Sub

    Private Sub Se_button_Background_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Se_button_Background.Click
        Dim OFD As New OpenFileDialog()
        OFD.FileName = "" ' 默认文件名
        OFD.DefaultExt = ".png" ' 默认文件扩展名
        OFD.Filter = "图像文件 (*.bmp;*.gif;*.jpg;*.jpeg;*.png)|*.bmp;*.gif;*.jpg;*.jpeg;*.png" ' 文件扩展名过滤器

        ' 显示打开文件对话框
        Dim result? As Boolean = OFD.ShowDialog()
        Dim LeftCanvas() As Canvas = {Canvas_CharacterLeft, Canvas_CharacterLeft_Wolfgang, Canvas_FoodLeft, Canvas_ScienceLeft, Canvas_CookingSimulatorLeft, Canvas_AnimalLeft, Canvas_AnimalLeft_Krampus, Canvas_AnimalLeft_Apackim_baggims, Canvas_AnimalLeft_PigKing, Canvas_AnimalLeft_Yaarctopus, Canvas_NaturalLeft_B, Canvas_NaturalLeft_P, Canvas_GoodsLeft_M, Canvas_GoodsLeft_E, Canvas_GoodsLeft_S, Canvas_GoodsLeft_A, Canvas_GoodsLeft_T, Canvas_GoodsLeft_P, Canvas_GoodsLeft_PL, Canvas_GoodsLeft_U, Canvas_GoodsLeft_C, Canvas_GoodsLeft_B, Canvas_GoodsLeft_BFT, Canvas_GoodsLeft_MIAB, Canvas_Setting}
        Dim RightWrapPanel() As WrapPanel = {WrapPanel_Character, WrapPanel_Food, WrapPanel_Science, WrapPanel_CookingSimulator, WrapPanel_Animal, WrapPanel_Natural, WrapPanel_Goods}

        '' 处理文件对话框结果
        'If result = True Then
        '    ' 打开文档
        '    Dim filename As String = OFD.FileName
        'End If

        Try
            BackGroundBorder.Visibility = Visibility.Visible
            Dim PictruePath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\JiHuangBaiKe\"
            If (Directory.Exists(PictruePath)) = False Then
                Directory.CreateDirectory(PictruePath)
            End If
            Dim filename = Path.GetFileName(OFD.FileName)
            Try
                FileIO.FileSystem.CopyFile(OFD.FileName, PictruePath & filename, True)
            Catch ex As Exception
            End Try
            Dim brush As New ImageBrush
            brush.ImageSource = New BitmapImage(New Uri(PictruePath & filename))
            BackGroundBorder.Background = brush
            Reg_Write_string("Background", PictruePath & filename)
        Catch ex As Exception
            MsgBox("没有选择正确的图片")
            For i = 0 To LeftCanvas.Length - 1
                LeftCanvas(i).Background.Opacity = 1
            Next
            For i = 0 To RightWrapPanel.Length - 1
                RightWrapPanel(i).Background.Opacity = 1
            Next
        End Try

        Dim RegReadBG As String = Reg_Read_string("Background")
        If RegReadBG <> "" Then
            For i = 0 To LeftCanvas.Length - 1
                LeftCanvas(i).Background.Opacity = PanelAlpha
            Next
            For i = 0 To RightWrapPanel.Length - 1
                RightWrapPanel(i).Background.Opacity = PanelAlpha
            Next
            Se_TextBlock_Alpha.Foreground = Brushes.Black
            Setting_slider_Alpha.IsEnabled = True
        Else
            Se_TextBlock_Alpha.Foreground = Brushes.Silver
            Setting_slider_Alpha.IsEnabled = False
        End If

    End Sub

    Private Sub Se_button_Background_Clear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Se_button_Background_Clear.Click
        BackGroundBorder.Visibility = Visibility.Collapsed
        Reg_Write_string("Background", "")
        Dim LeftCanvas() As Canvas = {Canvas_CharacterLeft, Canvas_CharacterLeft_Wolfgang, Canvas_FoodLeft, Canvas_ScienceLeft, Canvas_CookingSimulatorLeft, Canvas_AnimalLeft, Canvas_AnimalLeft_Krampus, Canvas_AnimalLeft_Apackim_baggims, Canvas_AnimalLeft_PigKing, Canvas_AnimalLeft_Yaarctopus, Canvas_NaturalLeft_B, Canvas_NaturalLeft_P, Canvas_GoodsLeft_M, Canvas_GoodsLeft_E, Canvas_GoodsLeft_S, Canvas_GoodsLeft_A, Canvas_GoodsLeft_T, Canvas_GoodsLeft_P, Canvas_GoodsLeft_PL, Canvas_GoodsLeft_U, Canvas_GoodsLeft_C, Canvas_GoodsLeft_B, Canvas_GoodsLeft_BFT, Canvas_GoodsLeft_MIAB, Canvas_Setting}
        For i = 0 To LeftCanvas.Length - 1
            LeftCanvas(i).Background.Opacity = 1
        Next
        Dim RightWrapPanel() As WrapPanel = {WrapPanel_Character, WrapPanel_Food, WrapPanel_Science, WrapPanel_CookingSimulator, WrapPanel_Natural, WrapPanel_Animal, WrapPanel_Goods}
        For i = 0 To RightWrapPanel.Length - 1
            RightWrapPanel(i).Background.Opacity = 1
        Next
        Se_TextBlock_Alpha.Foreground = Brushes.Silver
        Setting_slider_Alpha.IsEnabled = False
    End Sub

    Private Sub Setting_slider_Alpha_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles Setting_slider_Alpha.ValueChanged
        Dim Alpha As Integer = Setting_slider_Alpha.Value
        PanelAlpha = Alpha / 100
        Se_TextBlock_Alpha.Text = "面板不透明度 : " & Alpha & "%"
        Dim LeftCanvas() As Canvas = {Canvas_CharacterLeft, Canvas_CharacterLeft_Wolfgang, Canvas_FoodLeft, Canvas_ScienceLeft, Canvas_CookingSimulatorLeft, Canvas_AnimalLeft, Canvas_AnimalLeft_Krampus, Canvas_AnimalLeft_Apackim_baggims, Canvas_AnimalLeft_PigKing, Canvas_AnimalLeft_Yaarctopus, Canvas_NaturalLeft_B, Canvas_NaturalLeft_P, Canvas_GoodsLeft_M, Canvas_GoodsLeft_E, Canvas_GoodsLeft_S, Canvas_GoodsLeft_A, Canvas_GoodsLeft_T, Canvas_GoodsLeft_P, Canvas_GoodsLeft_PL, Canvas_GoodsLeft_U, Canvas_GoodsLeft_C, Canvas_GoodsLeft_B, Canvas_GoodsLeft_BFT, Canvas_GoodsLeft_MIAB, Canvas_Setting}
        For i = 0 To LeftCanvas.Length - 1
            LeftCanvas(i).Background.Opacity = PanelAlpha
        Next
        Dim RightWrapPanel() As WrapPanel = {WrapPanel_Character, WrapPanel_Food, WrapPanel_Science, WrapPanel_CookingSimulator, WrapPanel_Animal, WrapPanel_Natural, WrapPanel_Goods}
        For i = 0 To RightWrapPanel.Length - 1
            RightWrapPanel(i).Background.Opacity = PanelAlpha
        Next
    End Sub
#End Region

End Class
