using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class LinkedList
    {
        private Node head;
        private Node last;
        private int count = 0;

        public Node Head
        {
            get { return head; }
        }
        public Node Last
        {
            get { return last; }
        }
        public int Count
        {
            get { return count; }
        }

        #region Methods
        public void AddNodeToEnd(Node node)
        {
            if(Head == null)
            {
                head = node;
                last = node;
            }
            else
            {
                last.Next = node;
                last = last.Next;
            }
            count++;
        }
        public void AddNodeToHead(Node node)
        {
            if( head == null)
            {
                head = node;
                last = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.Next = temp;
            }
            count++;
        }

        /// <summary>
        /// Remove duplicates
        /// </summary>
        public void RemoveDuplicateNodes()
        {
            Dictionary<int, Node> uniqueNodes = new Dictionary<int, Node>();

            if(head == null)
            {
                return;
            }
            Node track = head.Next;
            Node previous = head;
            uniqueNodes.Add(head.Data, head);

            while(track != null)
            {
                if (uniqueNodes.ContainsKey(track.Data))
                {
                    previous.Next = track.Next;
                    track = track.Next;
                    count--;

                    if (track == null)
                    {
                        last = previous;
                    }
                }
                else
                {
                    uniqueNodes.Add(track.Data, track);
                    previous = track;
                    track = track.Next;
                }
            }
        }
        /// <summary>
        /// Find nth to last element
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Node ReturnNthToLast(int n)
        {
            if(count < n)
            {
                return null;
            }
            if(count == n)
            {
                return head;
            }
            Node track = head;
            int travel = count - n;

            while(travel > 0)
            {
                track = track.Next;
                travel--;
            }
            return track;
        }
        /// <summary>
        /// Given a node, delete from Linked list
        /// </summary>
        /// <param name="node"></param>
        public void DeleteNode(Node node)
        {
            Node track = head;
            Node previous = head;

            while(track != node && track != null)
            {
                previous = track;
                track = track.Next;
            }
            if( track == null)
            {
                return;
            }
            if(track == node)
            {
                if (track == head)
                {
                    head = track.Next;
                }
                else
                {
                    previous.Next = track.Next;
                    if (previous.Next == null)
                    {
                        last = previous;
                    }
                }
                count--;
                return;
            }
        }
        #endregion
    }
}
