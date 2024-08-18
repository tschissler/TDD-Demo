import random

class MasterMindLogic:
    @staticmethod
    def receive_code(level):
        code = ""
        for _ in range(4):
            code += chr(ord('A') + random.randint(0, level + 1))
        return code

    @staticmethod
    def get_guess_feedback(code, input_code):
        return "GetGuessFeedback not implemented yet. Try to apply TDD practices and implement it now!"
