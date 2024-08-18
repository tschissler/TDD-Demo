from masterMindLogic import MasterMindLogic

class MasterMind:
    def run(self):
        print("Hello, welcome to the great game of MasterMind!")
        print()
        print("Which level do you want to play (1-9)?")

        level = 0

        while level < 1 or level > 9:
            level = int(input())

        print()
        print()

        upper_option = chr(ord('A') + level + 2)
        print(f"Great, we will play on level {level}. This means the options for each position are 'A' - '{upper_option}'")
        print()
        print("I have received the code. It has 4 positions. Please start your quest in guessing it.")

        code_correct = False
        round = 1

        code = MasterMindLogic.receive_code(level)
        input_code = ""

        while input_code != code:
            print(f"--- Round {round} ---")
            print("Enter your guess (4 positions): ")
            input_code = input().upper()
            print(f"Your guess delivers this result (C=correct input | P=correct position): {MasterMindLogic.get_guess_feedback(code, input_code)}")
            round += 1

        print()
        print("###############################################################")
        print("Congratulations, you found the secret code!")
        print(f"It took you {round-1} rounds.")
        print("###############################################################")

if __name__ == "__main__":
    game = MasterMind()
    game.run()
