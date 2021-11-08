from FiniteAutomata import FiniteAutomata


class UI:

    def __readFA(self):
        self.fa = FiniteAutomata.readFromFile('FA.in')

    def __displayAll(self):
        print(self.fa)

    def __displayStates(self):
        print("States: " + str(self.fa.Q))

    def __displayAlphabet(self):
        print("Alphabet: " + str(self.fa.E))

    def __displayTransitions(self):
        print("Transitions: " + str(self.fa.S))

    def __displayFinalStates(self):
        print("Final states: " + str(self.fa.F))

    def __checkDFA(self):
        if self.fa.isDfa():
            print("Finite Automata is a DFA!")
        else:
            print("Finite Automata is not a DFA!")

    def __checkAccepted(self):
        sequence = input()
        if self.fa.isAccepted(sequence):
            print("Sequence is accepted!")
        else:
            print("Sequence not is accepted!")

    def __displayMenu(self):
        print()
        print("1. Read Finite Automata from file")
        print("2. Display Finite Automata")
        print("3. Display states")
        print("4. Display alphabet")
        print("5. Display transitions")
        print("6. Display final states")
        print("7. Check if Finite Automata is DFA")
        print("8. Check if the sequence is accepted")
        print("9. Exit")

    def run(self):
        while True:
            self.__displayMenu()
            print("->")
            command = input()
            if command == "1":
                self.__readFA()
            if command == "2":
                self.__displayAll()
            if command == "3":
                self.__displayStates()
            if command == "4":
                self.__displayAlphabet()
            if command == "5":
                self.__displayTransitions()
            if command == "6":
                self.__displayFinalStates()
            if command == "7":
                self.__checkDFA()
            if command == "8":
                self.__checkAccepted()
            elif command == "9":
                break
            else:
                continue