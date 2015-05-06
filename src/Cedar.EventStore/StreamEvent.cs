﻿namespace Cedar.EventStore
{
    using System;
    using System.Collections.Generic;

    public sealed class StreamEvent
    {
        public readonly string Checkpoint;
        public readonly string Json;
        public readonly Guid EventId;
        public readonly IReadOnlyCollection<byte> Metadata;
        public readonly int SequenceNumber;
        public readonly string StoreId;
        public readonly string StreamId;

        public StreamEvent(
            string storeId,
            string streamId,
            Guid eventId,
            int sequenceNumber,
            string checkpoint,
            string json,
            IReadOnlyCollection<byte> metadata)
        {
            StoreId = storeId;
            EventId = eventId;
            StreamId = streamId;
            SequenceNumber = sequenceNumber;
            Checkpoint = checkpoint;
            Json = json;
            Metadata = metadata;
        }
    }
}