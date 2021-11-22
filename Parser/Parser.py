class Parser: 
    
    def __init__(self, grammar): 
        self.__grammar = grammar
        self.__workingStack = []
        self.__inputStack = []
        self.__output = [] 
        
    def closure(self, productions): 
        
        if productions == []:
            return None
        C = productions
        finished = False 
        
        while not finished:
            finished = True 
            for dottedProd in C:
                dotIndex = dottedProd[1].index('.')
                alpha = dottedProd[1][:dotIndex]
                Bbeta = dottedProd[1][dotIndex + 1:]

                if len(Bbeta) == 0: 
                    continue
                    
                B = Bbeta[0]
                if self.__grammar.isTerminal(B): 
                    continue
                    
                for prod in self.__grammar.getProductionsFor(B):
                    dottedProd = (prod[0], ['.'] + prod[1])
                    if dottedProd not in C: 
                        C += [ dottedProd ]
                        finished = False 
        return C
        
        def goTo(self, state, symbol):
            pass

        def getCannonicalCollection(self): 
            pass
