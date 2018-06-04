using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {
		cell,
		cell_1,
		cell_2,
		cell_3,
		cell_4,
		cell_5,
		mirror,
		cell_mirror,
		cell_mirror_1,
		cell_mirror_2,
		sheets_0,
		sheets_1,
		lock_0,
		lock_1,
		lock_2,
		freedom,
		corridor_0,
		corridor_left,
		corridor_right,
		corridor_right_companion,
		corridor_left_companion,
		corridor_roam_left,
		corridor_roam_right,
		back_to_door,
		prisoner_left,
		prisoner_right,
		prisoner_right_companion,
		prisoner_left_companion,
		help_left,
		help_right,
		continue_left,
		continue_right,
		continue_right_all,
		continue_left_all,
		server_room_left,
		server_room_right,
		final_door,
		control_room_left,
		control_room_right,
		ending_alone,
		ending_prisoner_left,
		ending_turn_back,
		ending_prisoner_right,
		ending_prisoner_right_all,
		final_revelation,
		};

		private States myState;

		// Use this for initialization
		void Start () {

		myState = States.cell;

	}

	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {
			cell ();
		} else if (myState == States.cell_1) {
			cell_1 ();
		} else if (myState == States.cell_2) {
			cell_2 ();
		} else if (myState == States.cell_3) {
			cell_3 ();
		} else if (myState == States.cell_4) {
			cell_4 ();
		} else if (myState == States.cell_5) {
			cell_5 ();
		} else if (myState == States.sheets_0) {
			sheets_0 ();
		} else if (myState == States.sheets_1) {
			sheets_1 ();
		} else if (myState == States.lock_0) {
			lock_0 ();
		} else if (myState == States.lock_1) {
			lock_1 ();
		} else if (myState == States.lock_2) {
			lock_2 ();
		} else if (myState == States.mirror) {
			mirror ();
		} else if (myState == States.cell_mirror) {
			mirror_1 ();
		} else if (myState == States.cell_mirror_1) {
			mirror_2 ();
		} else if (myState == States.cell_mirror_2) {
			mirror_3 ();
		} else if (myState == States.corridor_0) {
			corridor_0 ();
		} else if (myState == States.back_to_door) {
			back_to_door ();
		} else if (myState == States.corridor_left) {
			corridor_left ();
		} else if (myState == States.corridor_right) {
			corridor_right ();
		} else if (myState == States.corridor_right_companion) {
			corridor_right_companion ();
		} else if (myState == States.corridor_left_companion) {
			corridor_left_companion ();
		} else if (myState == States.corridor_roam_left) {
			corridor_roam_left ();
		} else if (myState == States.corridor_roam_right) {
			corridor_roam_right ();
		} else if (myState == States.prisoner_left) {
			prisoner_left ();
		} else if (myState == States.help_left) {
			help_left ();
		} else if (myState == States.prisoner_right) {
			prisoner_right ();
		} else if (myState == States.prisoner_right_companion) {
			prisoner_right_companion ();
		} else if (myState == States.prisoner_left_companion) {
			prisoner_left_companion ();
		} else if (myState == States.help_right) {
			help_right ();
		} else if (myState == States.final_door) {
			final_door ();
		} else if (myState == States.continue_left) {
			continue_left ();
		} else if (myState == States.continue_right) {
			continue_right ();
		} else if (myState == States.continue_right_all) {
			continue_right_all ();
		} else if (myState == States.continue_left_all) {
			continue_left_all ();
		} else if (myState == States.server_room_left) {
			server_room_left ();
		} else if (myState == States.server_room_right) {
			server_room_right ();
		} else if (myState == States.ending_alone) {
			ending_alone ();
		} else if (myState == States.ending_prisoner_left) {
			ending_prisoner_left ();
		} else if (myState == States.ending_prisoner_right) {
			ending_prisoner_right ();
		} else if (myState == States.ending_prisoner_right_all) {
			ending_prisoner_right_all ();
		} else if (myState == States.final_revelation) {
			final_revelation ();
		}
	}

	#region State handler methods
	void cell () {
		text.text = "You jolt awake, you feel as though your head has been split open. " +
			"You reach your hand behind your head. As you look at your hand you see blood. " +
			"You look up still disorientated, where are you? How did you get here? Questions " +
			"flood your mind. You need to focus. You take a look at your surroundings. " +
			"You seem to be in some sort of old prison cell. There is a bed to your left " +
			"covered in dirty sheets, a mirror to the right that is hanging on the wall, " +
			"and straight ahead is a door.\n\n" +
			"Press S to view Sheets, M to view Mirror and L to view Lock";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		}
	}

	void cell_1 () {
		text.text = "You decide to keep searching your cell\n\n" +
			"Press S to view Sheets\n\n" +
			"Press M to view Mirror\n\n" +
			"Press L to view Lock";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		}
	}

	void sheets_0 () {
		text.text = "You walk over to the bed. It looks like it has been here for centuries. The " +
			"mattress is stained and springs are bursting through the tattered fabric. " +
			"It would be impossible to sleep on something this badly damaged, you think to " +
			"yourself. You look down at the dirty sheets. They are also discolored and there " +
			"are blood stains on them. You decide not to touch them. Guess you will have to get " +
			"answers somewhere else.\n\n" +
			"Press R to Return to roaming your cell";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_1;
		}
	}

	void sheets_1 () {
		text.text = "You point the mirror at the sheets.....nothing happens. Well guess you will " +
			"have to use the mirror another way to get out of here.\n\n" +
			"Press U to use the mirror\n\n" +
			"Press I to inspect the mirror further\n\n" +
			"Press L to look at the lock";

		if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.cell_mirror_1;
		} else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.cell_mirror_2;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_1;
		}
	}

	void lock_0 () {
		text.text = "You step forward until you are standing in front of door to your prison cell. " +
			"You reach out and give the door a push. Locked! That would have been too easy, " +
			"you say to yourself. The door appears to have a keyhole unlike anything you " +
			"have ever seen before. You feel around in your pockets but your pockets are empty. " +
			"There has to be a way to open the door. You should keep searching.\n\n" +
			"Press R to Return to roaming your cell";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_1;
		}

	}

	void lock_1 () {
		text.text = "You turn and point the mirror at the door.....again nothing happens. " +
			"Maybe you could smash the mirror but you don't see how destorying the mirror " +
			"would help in any way. There has to be something else something your still " +
			"missing.\n\n" +
			"Press U to use the mirror\n\n" +
			"Press I to inspect the mirror further\n\n" +
			"Press S to look at the sheets";

		if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.cell_mirror_1;
		} else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.cell_mirror_2;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		}

	}

	void lock_2 () {
		text.text = "You walk over to the door. Key in hand you place the key inside the lock. " +
			"It seems to be a perfect fit. You turn the key and you hear a click. You  " +
			"feel a sense of excitement but also panic as you have no idea what else this " +
			"place has in store. You slowly push the door. It opens and you walk out of " +
			"your cell. You did it!\n\n" +
			"Press W to Walk out of your cell";

		if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.corridor_0;
		}

	}

	void mirror () {
		text.text = "You turn to the mirror hanging on the wall and walk towards it. The mirror is " +
			"smudged and covered in dust. You use your sleeve to clean it off. Some dust falls " +
			"from the wall behind it. You look and see that the mirror is loose. Should you try " +
			"to pull it off the wall?\n\n" +
			"Press R to Return to roaming your cell\n\n" +
			"Press P to pull the mirror off the wall";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_1;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell_mirror;
		}

	}

	void mirror_1 () {
		text.text = "You grab the mirror with both hands and begin to pull. The mirror comes off the " +
			"wall as dust falls to the floor. Your not sure what good a mirror will do but " +
			"maybe it will help you find a way out of the cell.\n\n" +
			"Press U to use the mirror\n\n" +
			"Press I to inspect the mirror further\n\n" +
			"Press S to look at the sheets\n\n" +
			"Press L to look at the lock";

		if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.cell_mirror_1;
		} else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.cell_mirror_2;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_1;
		}
	}

	void mirror_2 () {
		text.text = "You look into the mirror. Your hair is messy and your face is covered in dirt and " +
			"scratches. You have been better that's for sure. There's nothing else the mirror " +
			"will tell you.\n\n" +
			"Press I to Inspect the mirror further";

		if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.cell_mirror_2;
		}

	}

	void mirror_3 () {
		text.text = "Turning the mirror over you see the back is covered by a brown paper. You could " +
			"easily tear through it if you tried. After a few seconds you decide to rip the paper " +
			"off. As you do you see what looks like a key. You reach up and grab the key. You look " +
			"over at the lock. Could this key be your way out of here? Why was it hidden almost " +
			"as if you were suppposed to find it? Well only one way to find out.\n\n" +
			"Press U to use the key\n\n";
		if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.lock_2;
		}
	}

	void corridor_0 () {
		text.text = "You turn and grab the key from the lock, never know if it will come in handy " +
			"later on. The door to prison is left slightly ajar. You push it open and step " +
			"into a long dark hallway. Torches light up sections of the darkness. There is  " +
			"a path to the left and path to the right. Your unsure which way to take, but you  " +
			"You should decide quickly.\n\n" +
			"Press L to go Left\n\n" +
			"Press R to go Right";

		if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.corridor_left;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_right;
		}

	}

	void back_to_door () {
		text.text = "You turn back around and decide to open the door\n\n" +
			"Press M to make your way through\n\n";

		if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.cell_2;
		}
	}

	// Need to finish this section
	void corridor_left () {
		text.text = "You decide to head left. You feel your way along the wall. You hear a slight " +
			"hum overhead. You make out what looks like some sort of drone. It quickly vanishes " +
			"into the darkness. If you were unsure before you are now positive that you are being " +
			"watched. You continue down the corridor. You come to a door.\n\n" +
			"Press R to Return to Roaming\n\n" +
			"Press O to Open the door";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_roam_left;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.cell_2;
		}

	}

	void corridor_right () {
		text.text = "You decide to head right. You feel your way along the wall. As you make your way " +
			"a little further you see a blinking red light. It looks to be an old security " +
			"camera. How long have you been watched? Are they the ones helping you? You continue " +
			"a little further you see a door. You ponder what your next move should be.\n\n" +
			"Press R to return to Roaming\n\n" +
			"Press O to Open the door";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_roam_right;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.cell_3;
		}

	}

	void corridor_right_companion () {
		text.text = "You decide to head right. You feel your way along the wall. As you make your way " +
			"a little further your companion taps your shoulder. They point to a blinking red light.\n\n" +
			"'We are being watched should be careful.'\n\n" +
			"You nod as you continue down the corridor. You come to a door. You ponder what your next move should be.\n\n" +

			"Press R to return to Roaming\n\n" +
			"Press O to Open the door";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_roam_right;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.cell_4;
		}
	}

	void corridor_left_companion () {
		text.text = "You decide to head left. You feel your way along the wall. As you make your way " +
			"a little further your companion taps your shoulder. They point to a drone hovering above you.\n\n" +
			"'We are being watched should be careful.'\n\n" +
			"You nod as you continue down the corridor. You come to a door. You ponder what your next move should be.\n\n" +

			"Press R to return to Roaming\n\n" +
			"Press O to Open the door";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_roam_left;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.cell_5;
		}
	}

	void corridor_roam_left () {
		text.text = "You continue to roam the corridor. After a few steps you see another doorway come into view. " +
			"You walk until you are standing in front of it.\n\n" +
			"Press O to open the door.\n\n" +
			"Press T to turn around and start heading right.\n\n";

		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.final_door;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.corridor_right;
		}
	}

	void corridor_roam_right () {
		text.text = "You continue to roam the corridor. After a few steps you see another doorway come into view. " +
			"You walk until you are standing in front of it.\n\n" +
			"Press O to open the door.\n\n" +
			"Press T to turn around and start heading left.\n\n";

		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.final_door;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.corridor_left;
		}
	}

	void final_door () {
		text.text = "You walk through the door. To your surprise you seem to be in an entirely different place. " +
			"You see computers hooked up to large servers. You turn to look at the corridor you just came from. " +
			"You could have sworn you were back in the dark ages but now your not sure what to believe. " +
			"These machines seem familiar to you but you remember nothing else. At the far end of the room you see " +
			"a mirror. After looking at it for a moment you get an idea. You grab a computer and throw it through glass. " +
			"As the glass shatters you see a light. This could be your way out.\n\n" +
			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.ending_alone;
		}
	}

	void cell_2 () {
		text.text = "You open the door which leads to a cell similar to the one you just escaped " +
			"from. It's dark inside the cell. You take a step and loose your footing. You " +
			"tumble down a few stairs and land hard on the cement floor. You slowly push " +
			"yourself up. Just as you are about to stand you hear a voice pierce the silence.\n\n" +
			"'Mariel is that you?'\n\n" +
			"You are stunned. You don't recognize the voice but maybe they have answers.\n\n" +
			"Press A to approach the cell\n\n" +
			"Press R to Run out of the room and back to the corridor";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.prisoner_left;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_roam_left;
		}
	}

	void cell_3 () {
		text.text = "You open the door which leads to a cell similar to the one you just escaped " +
			"from. It's dark inside the cell. You take a step and loose your footing. You " +
			"tumble down a few stairs and land hard on the cement floor. You slowly push " +
			"yourself up. Just as you are about to stand you hear a voice pierce the silence.\n\n" +
			"'Who's there? Please help me.'\n\n" +
			"You are stunned. You don't recognize the voice but maybe they have answers.\n\n" +
			"Press A to approach the cell\n\n" +
			"Press R to Run out of the room and back to the corridor";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.prisoner_right;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_roam_right;
		}
	}

	void cell_4 () {
		text.text = "You open the door which leads to a cell similar to the one you and your companion " +
			"just escaped from. You both slowly make your way down the stairs. You hear a rustling. Someone " +
			"else is in the room. A voice pierces the darkness.\n\n" +
			"'Hello is anyone there?'\n\n" +
			"You turn to your companion who motions to leave. You press on slowly moving forward until you feel " +
			"the cold prison bars in your hands.\n\n " +

			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.prisoner_right_companion;
		}
	}

	void cell_5 () {
		text.text = "You open the door which leads to a cell similar to the one you and your companion " +
			"just escaped from. You both slowly make your way down the stairs. You hear a rustling. Someone " +
			"else is in the room. A voice pierces the darkness.\n\n" +
			"'Hello is anyone there?'\n\n" +
			"You turn to your companion who motions to leave. You press on slowly moving forward.\n\n " +

			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.prisoner_left_companion;
		}
	}

	void prisoner_left () {
		text.text = "You continue to follow the voice, running your hands along the floor until you feel cool metal in your hands. " +
			"The prisoner quickly grabs your hands.\n\n" +
			"'Please Mariel you have to help me. We don't have much time you have to help me get out of here.'\n\n" +
			"You take a step back.\n\n" +

			"Press A to ask how you can help\n\n" +

			"Press R to Run out of the room and back to the corridor";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.help_left;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_roam_left;
		}
	}

	void help_left () {
		text.text = "'To be honest I'm not sure how to get out exactly. I tried to search for anything I could find " +
			"that could open this door, but there just isn't anything here. How were you able to get out of your cell?'\n\n" +
			"You reach in your pocket and pull out an old rusty key and place it in the lock. With a slow turn you hear " +
			"a click and the door slowly opens.\n\n" +
			"You both turn and exit the cell.\n\n" +

			"Press L to turn left\n\n" +

			"Press R to turn right.";

		if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.continue_left;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_right_companion;
		}
	}

	void prisoner_right () {
		text.text = "You continue to follow the voice, running your hands along the floor until you feel cool metal in your hands. " +
			"The prisoner moves in their cell. They appear to be just as afraid of you as you are of them. You take a step back.\n\n " +

			"Press A to ask how you can help them.\n\n" +

			"Press R to Run out of the room and back to the corridor";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.help_right;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_roam_right;
		}
	}

	void prisoner_left_companion () {
		text.text = "You continue to follow the voice, running your hands along the floor until you feel cool metal in your hands. " +
			"'Mariel it's me, Julian.'\n\n" +
			"You take a step back. After a few moments you decide to open the prison door with your rusty key. The prisoner rushes out of their cell.\n\n" +
			"'I don't know where we are but I will do my best to help wherever I can.'\n\n" +
			"They turn and look at your other companion.\n\n" +
			"'Any friend of Mariels is a friend of mine.'\n\n" +
			"They pat your companion on the back and the three of you make your way out of the cell and back down the corridor.\n\n " +

			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.continue_left_all;
		}
	}

	void prisoner_right_companion () {
		text.text = "'Please help me. I don't know who put me here or why but I haven't been able to find a way out of this place.'\n\n" +
			"You turn to your companion who looks reluctant to help. You reach in your pocket. You still have the key. If it unlocked " +
			"the other cell it will probably work for this one as well. You decide to open the lock. The figure slowly steps out of the cell " +
			"the cell is dark but you can motion for them to follow you. The three of you make your way out of the cell.\n\n" +

			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.continue_right_all;
		}
	}

	void help_right () {
		text.text = "'I'm sorry its just that I have been here for so long. I didn't think I was ever getting out of this place. " +
			"I have searched high and low for anything to open this door but its no use. Do you know a way to open the door?'\n\n" +
			"You reach in your pocket and pull out an old rusty key. You place the key in the lock and turn. You hear a click. " +
			"and you are able to open the door.\n\n" +
			"You both turn and exit the cell.\n\n" +

			"Press L to turn left\n\n" +

			"Press R to turn right";

		if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.corridor_left_companion;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.continue_right;
		}
	}

	void continue_left () {
		text.text = "You decide to go left. You both move quickly along the wall. You see a door ahead. You stop and look at it. " +
			"You turn and look at your companion. They just nod as if to say you first. You push the door open. Inside are " +
			"a number of computers connected to large servers spread throughout the room. You turn to see your companion " +
			"looking at one screen in particular. It looks like camera footage of another cell. There is someone inside. " +
			"You not sure why your companion is looking at the screen but you decide to continue to survey the room. " +
			"You walk to the end of the room and stand in front of a mirror. Two way mirror probably just some way for..... " +
			"You look at the mirror something about this feels familiar. You pick up a computer and throw it at the glass. " +
			"As it shatters you see light. You believe that this is your way out.\n\n " +

			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.ending_prisoner_left;
		}
	}

	void continue_right () {
		text.text = "You decide to go right. You both move quickly along the wall. You see a door ahead. You stop and look at it. " +
			"You turn and look at your companion. They nod as if to say they are right behind you. You push the door open. Inside " +
			"are a number of computers connected to large servers spread throughout the room. Your companion rushes to one of the computers.\n\n" +
			"'You helped me, let me try to help you. I might be able to hack into the system and find out where we are and who is behind this.'\n\n" +
			"As they begin to type you begin to walk to a mirror at the far side of the room. Your companion looks up.\n\n" +
			"'Does the name Kane mean anything to you?'\n\n" +
			"You shake your head as you grab a computer and throw it through the mirror. " +
			"As it shatters you see light. You believe that this is your way out.\n\n " +

			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.ending_prisoner_right;
		}
	}

	void continue_right_all () {
		text.text = "You continue down the right corridor. All three of you move along the wall until you come to a door. " +
			"You push the door open. You see a room full of computers that are connected to large servers spread throughout " +
			"the room. One of your companions runs over to a computer.\n\n" +
			"'I might be able to hack the computer and find out something about this place.'\n\n" +
			"Your other companion walks over to a mirror at the far end of the room.\n\n" +
			"'This looks like a two way mirror. It could lead to a way out. Maybe we could use one of these computers to break it.'\n\n" +
			"Your other companion motions for you.\n\n" +

			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.server_room_right;
		}
	}

	void server_room_right () {
		text.text = "You make your way over to your companion leans in close and points at the monitor.\n\n" +
			"'Does the name Kane mean anything to you?'\n\n" +
			"You shake your head.\n\n" +
			"'How much do you know about your friend over there? Cause I accessed footage from the cameras and drones and it appears that " +
			"it was all orchestrated by someone named Kane.'\n\n" +
			"All of the sudden you hear a crash as pieces of the mirror hit the floor. You both look up to see your other companion " +
			"take an elegant bow.\n\n" +

			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.ending_prisoner_right_all;
		}
	}

	void continue_left_all () {
		text.text = "You continue down the left corridor. All three of you move along the wall until you come to a door. " +
			"You push the door open. You see a room full of computers that are connected to large servers spread throughout " +
			"the room. One of your companions runs over to a computer.\n\n" +
			"'I might be able to hack the computer and find out something about this place.'\n\n" +
			"The other companion walks over to a mirror at the far end of the room.\n\n" +
			"'This looks like a two way mirror could lead to a way out. Maybe we could use one of these computers to break it.'\n\n" +
			"Your other companion motions for you.\n\n" +

			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.server_room_left;
		}
	}

	void server_room_left () {
		text.text = "You make your way over to your companion leans in close and points at the monitor.\n\n" +
			"'Does the name Kane mean anything to you?'\n\n" +
			"You shake your head.\n\n" +
			"'How much do you know about your friend over there? Cause I accessed footage from the cameras and drones and it appears that " +
			"it was all orchestrated by someone named Kane.'\n\n" +
			"All of the sudden you hear a crash as pieces of the mirror hit the floor. You both look up to see your other companion " +
			"take an elegant bow.\n\n" +

			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.ending_prisoner_right_all;
		}
	}

	// Create three endings for left
	void ending_alone () {
		text.text = "As you climb through the glass you see a picture of yourself standing next to someone else. The two of you " +
			"seem close. You remember the person in the picture. Memories begin to flood your mind. This place you know it. The " +
			"surveillance, the computers, the tech. This is all connected somehow. You hear something behind you. You spin around " +
			"a large figure stands before you. Before you can do anything you are on the ground gasping for air. You look up to see " +
			"some sort of gas coming from vents in the ceiling. As you begin to loose consciousness thing comes to mind.\n\n" +
			"Kane!\n\n" +
			"Your eyes close and all is dark.\n\n" +

			"Press C to continue to solve the mystery";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.cell;
		}
	}

	void ending_prisoner_left () {
		text.text = "Your companion smiles.\n\n" +
			"'Wow that was amazing. I'm going to make sure the way is clear.'\n\n" +
			"Before you can say a word they are out of sight. You climb through the window. You take a few steps " +
			"forward when you see a piece of paper on the ground. You inspect it. It looks like a letter of some kind. It appears to " +
			"have been ripped in half. It reads right is the way open the door and find what you seek. You hear your companion in the " +
			"distance.\n\n" +
			"'Turn back they know!'\n\n" +
			"You look up to see a gas being vented into the room. You climb out of the window " +
			"and sprint for the door. It slams shut before you can get there. You fall to the ground still holding the note in one hand. " +
			"Your eyes close.\n\n" +

			"Press C to continue to solve the mystery";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.cell;
		}
	}

	void ending_prisoner_right () {
		text.text = "Your companion looks unphased as they continue to search. As you step through you see a torn piece of paper on the ground. " +
			"You pick it up and bring it to your companion. They reach into there pocket and pull out a similiar piece of paper. " +
			"They appear to go together as you connect them. You see gas begin to fill the room. You both fall to your knees. " +
			"As your eyes close you see the lower half of the paper says\n\n" +
			"3 = Freedom.\n\n" +
			"Your eyes close and the room goes black. \n\n" +

			"Press C to continue to solve the mystery";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.cell;
		}
	}

	void ending_prisoner_right_all () {
		text.text = "You move to the window. Your other companion climbs through. You follow close behind. You see a picture on the ground " +
			"As you pick it you are called back to the computer. The two of you rush back.\n\n" +
			"'This is all some sort of goverment facility and whoever this Kane is, they have something to do with it. We have to find a way out of here now!'\n\n" +
			"You hold up the picture that you found both of your companions look at it. One grabs the photo.\n\n" +
			"'I know who this is. This is you and Sean.'\n\n" +
			"You look confused but at the mention of that name a wave of memories flood your mind.\n\n" +
			
			"Press C to continue";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.final_revelation;
		}
	}

	void final_revelation () {
		text.text = "'That is how I know you, all three of us worked at Kane Industries.'\n\n" +
			"You remember you and Sean were working on an experimental gas for the government. One to wipe out memories temporarily and make the " +
			"subject highly suggestable. If they wanted to test the gas that means Sean could also be somewhere in this facility. You look up at your " +
			"two companions.\n\n" +
			"'I'm going to rescue Sean. Are you two with me?'\n\n" +
			"After a brief second look at each other they nod. The three of you walk through the window, not entirely sure what will happen next, " +
			"but at least you will face it together.\n\n" +
			"You just completed this act of Prison. Mariel's story is far from over!\n\n" +

			"Press P to play the story again!";

		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;
		}
	}
	#endregion
}