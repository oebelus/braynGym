static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data) 
{
  SinglyLinkedListNode node = new(data);
  
  if (head == null) { 
      head = node;
      head.next = null;
  } else {
      SinglyLinkedListNode current = head; 
      while (current.next != null) {
          current = current.next;
      }
      current.next = node; 
  }
  
  return head;
}
