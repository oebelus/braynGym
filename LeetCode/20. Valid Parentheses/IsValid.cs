public bool IsValid(string s) {
    Stack<char> stack = [];

    int n = s.Length;

    for (int i = 0; i < n; i++) {
        char val = s[i];
        
        if (val == '(' || val == '{' || val == '[')
            stack.Push(val);
        else {
            if (stack.Count == 0) return false;
            char popped = stack.Pop();
            if (!((popped == '(' && val == ')') || (popped == '[' && val == ']') || (popped == '{' && val == '}')))
                return false;
        }
    }
    return stack.Count > 0 ? false : true;
}
