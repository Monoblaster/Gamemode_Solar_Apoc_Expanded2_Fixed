datablock AudioProfile(BrickedRefineryLoopSound)
{
   filename    = "./Sounds/BrickedRefineryLoop.wav";
   description = AudioCloseLooping3d;
   preload = true;
};

datablock fxDTSBrickData(brickEOTWBrickedRefineryData)
{
	brickFile = "./Shapes/AlloyForge.blb";
	category = "Solar Apoc";
	subCategory = "Ore Processing";
	uiName = "Bricked Refinery";
	iconName = "Add-Ons/Gamemode_Solar_Apoc_Expanded2_Fixed/Modules/Power/Icons/BrickedRefinery";

	isPowered = true;
	powerType = "Machine";
	useHeatForPower = true;

	matterSize = 64;
	matterSlots["Input"] = 2;
	matterSlots["Output"] = 1;

	isProcessingMachine = true;
	automaticRecipe = true;
	processingType = "Refining";
	processSound = FurnaceLoopSound;
};
$EOTW::CustomBrickCost["brickEOTWBrickedRefineryData"] = 1.00 TAB "c1a872ff" TAB 512 TAB "Granite" TAB 128 TAB "Wood" TAB 128 TAB "Coal";
$EOTW::BrickDescription["brickEOTWBrickedRefineryData"] = "A very simple ore refinery that uses raw fuel instead of electric power.";

function brickEOTWBrickedRefineryData::onTick(%this, %obj) { %obj.runProcessingTick(); }

function brickEOTWBrickedRefineryData::getProcessingText(%this, %obj) {
	%heatText = %obj.machineHeat > 0 ? "\c2Machine Heated" : "\c7Not Fueled";

    if (isObject(%obj.processingRecipe))
		return "Recipe:\c3" SPC cleanRecipeName(%obj.processingRecipe) SPC "\c6|" SPC %heatText;
	else
		return "\c0No Recipe (Automatic) \c6|" SPC %heatText;
}

datablock fxDTSBrickData(brickEOTWBrickedCokeOvenData)
{
	brickFile = "./Shapes/AlloyForge.blb";
	category = "Solar Apoc";
	subCategory = "Ore Processing";
	uiName = "Coke Oven";
	iconName = "Add-Ons/Gamemode_Solar_Apoc_Expanded2_Fixed/Modules/Power/Icons/CokeOven";

	isPowered = true;
	powerType = "Machine";
	useHeatForPower = true;

	matterSize = 64;
	matterSlots["Input"] = 2;
	matterSlots["Output"] = 1;

	isProcessingMachine = true;
	automaticRecipe = true;
	processingType = "Pyrolysis";
	processSound = FurnaceLoopSound;
};
$EOTW::CustomBrickCost["brickEOTWBrickedCokeOvenData"] = 1.00 TAB "c1a872ff" TAB 512 TAB "Granite" TAB 128 TAB "Wood" TAB 128 TAB "Coal";
$EOTW::BrickDescription["brickEOTWBrickedCokeOvenData"] = "Turn wood and coal into more useful charcoal and coke.";

function brickEOTWBrickedCokeOvenData::onTick(%this, %obj) { %obj.runProcessingTick(); }

function brickEOTWBrickedCokeOvenData::getProcessingText(%this, %obj) {
	%heatText = %obj.machineHeat > 0 ? "\c2Machine Heated" : "\c7Not Fueled";

    if (isObject(%obj.processingRecipe))
		return "Recipe:\c3" SPC cleanRecipeName(%obj.processingRecipe) SPC "\c6|" SPC %heatText;
	else
		return "\c0No Recipe (Automatic) \c6|" SPC %heatText;
}