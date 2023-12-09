class Set:
    def __init__(self):
        self.dictionary = {}
        
    def has(self, element):
        return element in self.dictionary
        
    def values(self):
        return self.dictionary.values()
        
    def add(self, element):
        if not self.has(element):
            self.dictionary[element] = element
            return True
        return False
        
    def delete(self, element):
        if self.has(element):
            del self.dictionary[element]
            return True
        return False
        
    def size(self):
        return len(self.dictionary)
