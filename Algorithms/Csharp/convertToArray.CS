public static int[] convertToArray(MultiListNode head) {
    head = flattenList(head);
    const MultiListNode placeholder = head;
    int length = 0;
    while(head != null) {
        length++
        head = head.next;
    }
    int[] array = new int[length];
    head = placeholder;
    for(int i = 0; head != null; i++) {
        array[i] = head.val;
        head = head.next;
    }
    return array;
}