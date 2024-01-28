SinglyLinkedListNode* reverse(SinglyLinkedListNode* llist) 
{
    SinglyLinkedListNode* head = llist;
    SinglyLinkedListNode* prev = NULL; 
    while (head != NULL) {
        SinglyLinkedListNode* nextNode = head->next;
        head->next = prev;
        prev = head; 
        head = nextNode;
    }
    head = prev;
    return head;
}
