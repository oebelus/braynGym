class CircularQueue:
    def __init__(self, size):
        self.queue = []
        self.read = 0
        self.write = 0
        self.max = size - 1
        
        while (size > 0):
            self.queue.append(None)
            size -= 1
    
    def enqueue(self, item): 
        if self.write >= self.max + 1 + self.read:
            return None
        self.queue[self.write % (self.max + 1)] = item
        self.write += 1
        return item
        
    def dequeue(self):
        if self.read >= self.write:
            return None
        item = self.queue[self.read % (self.max + 1)]
        self.queue[self.read % (self.max + 1)] = None
        self.read += 1
        return item
